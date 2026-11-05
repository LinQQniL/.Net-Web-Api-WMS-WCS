using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Data;
using MiddlewareDemo.Models;
using WMS.DATA.Entities;

namespace MiddlewareDemo.Services;

/// <summary>
/// 角色菜单权限服务：根据登录用户查询其角色可见的菜单树与按钮级权限。
///
/// 严格对应数据库现有的五张表：
///   UserInfo      用户（UserId 主键，另有 RoleId）
///   RoleInfo      角色（RoleId 主键）
///   MenuInfo      菜单（MenuId 主键，ParentId 自关联）
///   RoleMenuInfo  角色-菜单授权（RoleId + MenuId + MenuPowerId）
///   MenuPowerInfo 菜单权限明细（MenuPowerId + MenuId + 各操作位）
/// </summary>
public class UserMenuService
{
	private readonly AppDbContext _dbContext;

	public UserMenuService(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	/// <summary>
	/// 获取指定用户所属角色的树状菜单与权限列表。
	/// </summary>
	/// <param name="userId">用户 Id（GUID 字符串，来自 JWT 的 nameidentifier）</param>
	public async Task<ResultUserMenuDto> ShowUserMenuAsync(string? userId)
	{
		if (string.IsNullOrWhiteSpace(userId))
		{
			throw new ArgumentException("用户标识为空，无法获取菜单", nameof(userId));
		}

		// 1) 用户
		UserInfo user = await _dbContext.UserInfos
			.AsNoTracking()
			.FirstOrDefaultAsync(u => u.UserId == userId)
			?? throw new InvalidOperationException("用户不存在");

		if (string.IsNullOrWhiteSpace(user.RoleId))
		{
			throw new InvalidOperationException("该用户尚未分配角色，请联系管理员");
		}

		// 2) 角色
		RoleInfo role = await _dbContext.RoleInfos
			.AsNoTracking()
			.FirstOrDefaultAsync(r => r.RoleId == user.RoleId)
			?? throw new InvalidOperationException("获取用户角色失败，用户角色不存在");

		// 3) 角色授权 + 菜单 + 权限明细，一次性联表取出
		//    MenuPowerInfo 用 LEFT JOIN：某个菜单若没有对应权限记录，
		//    菜单本身仍应出现在树里，只是权限位全为 false。
		List<ResultMenuPowerInfoDto> rows = await (
				from rm in _dbContext.RoleMenuInfos
				join m in _dbContext.MenuInfos on rm.MenuId equals m.MenuId
				join p in _dbContext.MenuPowerInfos on rm.MenuPowerId equals p.MenuPowerId into pj
				from mp in pj.DefaultIfEmpty()
				where rm.RoleId == role.RoleId && m.State
				select new ResultMenuPowerInfoDto
				{
					MenuId = m.MenuId,
					ParentId = m.ParentId,
					ParentName = m.ParentName,
					Name = m.Name,
					Number = m.Number,
					LevelCode = m.LevelCode,
					ComponentName = m.ComponentName,
					Icon = m.Icon,
					Url = m.Url,
					Router = m.Router,
					JumpUrl = m.JumpUrl,
					Show = m.Show,
					Close = m.Close,
					KeepAlive = m.KeepAlive,
					State = m.State,
					Description = m.Description,

					MenuPowerId = rm.MenuPowerId,
					Display = mp == null || mp.Display,
					Insert = mp != null && mp.Insert,
					Update = mp != null && mp.Update,
					Delete = mp != null && mp.Delete,
					Save = mp != null && (mp.Save ?? false),
					Search = mp != null && (mp.Search ?? false),
					Export = mp != null && (mp.Export ?? false),
					Print = mp != null && (mp.Print ?? false),
					Import = mp != null && (mp.Import ?? false),
					Operates = mp == null ? null : mp.Operates
				})
			.AsNoTracking()
			.ToListAsync();

		// 4) 按菜单去重：一个菜单可能挂多条权限记录，组装树前先压成"一个菜单一条"
		List<ResultMenuPowerInfoDto> menuItems = rows
			.GroupBy(x => x.MenuId)
			.Select(g => g.First())
			.OrderBy(x => x.LevelCode, StringComparer.Ordinal)
			.ToList();

		// 5) 组装两级树：一级菜单（ParentId 为空或不在结果集内）+ 其直接子菜单
		HashSet<string> visibleIds = menuItems.Select(x => x.MenuId).ToHashSet();

		List<MenusDto> tree = new();
		foreach (ResultMenuPowerInfoDto parent in menuItems.Where(x =>
					 string.IsNullOrWhiteSpace(x.ParentId) || !visibleIds.Contains(x.ParentId!)))
		{
			MenusDto node = ToNode(parent);
			node.children = menuItems
				.Where(x => !string.IsNullOrWhiteSpace(x.ParentId) && x.ParentId == parent.MenuId)
				.Select(ToNode)
				.OrderBy(c => c.LevelCode, StringComparer.Ordinal)
				.ToList();
			tree.Add(node);
		}

		// 6) 权限列表：每个菜单-权限点一条，供前端控制按钮显隐
		List<MenuPowerDto> powers = rows
			.GroupBy(x => new { x.MenuId, x.MenuPowerId })
			.Select(g => g.First())
			.Select(x => new MenuPowerDto
			{
				MenuId = x.MenuId,
				MenuPowerId = x.MenuPowerId,
				Display = x.Display,
				Insert = x.Insert,
				Update = x.Update,
				Delete = x.Delete,
				Save = x.Save,
				Search = x.Search,
				Export = x.Export,
				Print = x.Print,
				Import = x.Import,
				Operates = x.Operates
			})
			.OrderBy(p => p.MenuId, StringComparer.Ordinal)
			.ToList();

		// 7) 汇总
		return new ResultUserMenuDto
		{
			Name = user.Name,
			UserName = user.UserName,
			Phone = user.Phone,
			Email = user.Email,
			RoleCode = role.Code,
			RoleName = role.Name,
			Menus = tree,
			MenuPowers = powers
		};
	}

	private static MenusDto ToNode(ResultMenuPowerInfoDto src)
	{
		return new MenusDto
		{
			MenuId = src.MenuId,
			ParentId = src.ParentId,
			ParentName = src.ParentName,
			Name = src.Name,
			Number = src.Number,
			LevelCode = src.LevelCode,
			ComponentName = src.ComponentName,
			Icon = src.Icon,
			Url = src.Url,
			Router = src.Router,
			JumpUrl = src.JumpUrl,
			Show = src.Show,
			Close = src.Close,
			KeepAlive = src.KeepAlive,
			State = src.State,
			Description = src.Description
		};
	}
}
