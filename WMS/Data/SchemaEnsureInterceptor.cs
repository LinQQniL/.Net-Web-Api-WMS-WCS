using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace MiddlewareDemo.Data;

/// <summary>
/// 数据库自愈拦截器：在任何用户 SQL 执行前，先确保数据库结构是最新的。
///
/// 为什么用拦截器：Program.cs 当前文件编码损坏（含 NUL 字节）无法安全编辑，
/// 拦截器经 AppDbContext.OnConfiguring 自动挂载，无需改启动代码。
///
/// 防递归：初始化自身也要执行 SQL，用 AsyncLocal 标记"正在初始化"，
/// 初始化期间产生的命令直接放行，不再次触发。
/// </summary>
public sealed class SchemaEnsureInterceptor : DbCommandInterceptor
{
	private static readonly SemaphoreSlim _Gate = new(1, 1);

	/// <summary>标记当前异步上下文是否正处于初始化中（防递归）</summary>
	private static readonly AsyncLocal<bool> _isInitializing = new();

	/// <summary>已完成的数据库（按连接串区分）</summary>
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, bool> _done = new();

	private readonly ILogger<SchemaEnsureInterceptor>? _logger;

	public SchemaEnsureInterceptor(ILogger<SchemaEnsureInterceptor>? logger = null)
	{
		_logger = logger;
	}

	public override async ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(
		DbCommand command,
		CommandEventData eventData,
		InterceptionResult<DbDataReader> result,
		CancellationToken cancellationToken = default)
	{
		await EnsureAsync(eventData.Context, cancellationToken).ConfigureAwait(false);
		return result;
	}

	private async Task EnsureAsync(DbContext? context, CancellationToken cancellationToken)
	{
		// 初始化途中产生的 SQL 直接放行，避免无限递归
		if (_isInitializing.Value)
		{
			return;
		}

		if (context is not AppDbContext db)
		{
			return;
		}

		string key = db.Database.GetConnectionString() ?? string.Empty;
		if (string.IsNullOrEmpty(key) || _done.ContainsKey(key))
		{
			return;
		}

		await _Gate.WaitAsync(cancellationToken).ConfigureAwait(false);
		try
		{
			if (_done.ContainsKey(key))
			{
				return;
			}

			_isInitializing.Value = true;
			try
			{
				_logger?.LogInformation("开始同步数据库结构…");
				await DatabaseInitializer.InitializeAsync(db, _logger).ConfigureAwait(false);
				_done[key] = true;
				_logger?.LogInformation("数据库结构同步完成");
			}
			catch (Exception ex)
			{
				// 初始化失败不阻断正常请求，记录后放行，避免整个站点不可用
				_logger?.LogError(ex, "数据库结构同步失败");
			}
			finally
			{
				_isInitializing.Value = false;
			}
		}
		finally
		{
			_Gate.Release();
		}
	}
}
