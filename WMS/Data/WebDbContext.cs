using Microsoft.EntityFrameworkCore;
using WMS.DATA;

namespace MiddlewareDemo.Data;

/// <summary>
/// Web 层数据库上下文。
///
/// 实体与映射统一由 WMS.DATA 层的 <see cref="WmsDbContext"/> 提供，这里只做继承，
/// 保证 Program.cs 里的 AddDbContext&lt;AppDbContext&gt; 注册保持不变。
///
/// 业务开发需要新增表时，请到 WMS.DATA\WmsDbContext.cs 按需添加 DbSet 与映射，
/// 不要在 Web 层重复定义上下文。
/// </summary>
public class AppDbContext : WmsDbContext
{
	public AppDbContext(DbContextOptions<WmsDbContext> options)
		: base(options)
	{
	}

    
}
