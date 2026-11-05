using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Data;
using MiddlewareDemo.Models;
using MiddlewareDemo.Services;

namespace WmsDomain.UserMuse;

/// <summary>
/// 领域层门面：把 Web 层的 UserMenuService 包装成领域调用。
/// 原文件整体使用 SqlSugar API（Context.Queryable / JoinQueryInfos / JoinType）
/// 且类壳未闭合、依赖的实体与 DTO 均不存在，已重写为 EF Core 实现。
/// </summary>
public class Muse
{
	private readonly UserMenuService _userMenuService;

	public Muse(UserMenuService userMenuService)
	{
		_userMenuService = userMenuService;
	}

	/// <summary>
	/// 获取用户所属角色的树状菜单权限
	/// </summary>
	public async Task<ResultUserMenuDto> ShowUserMenuAsync(string? userId)
	{
		return await _userMenuService.ShowUserMenuAsync(userId);
	}
}
