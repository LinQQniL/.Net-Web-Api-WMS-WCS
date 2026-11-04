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
/// 角色菜单权限服务（MenuService）。
///
/// 【为什么不用 LEFT JOIN 判断 mp == null】
/// MenuPowerInfo 与 RoleMenuInfo 都是 HasNoKey() 的无键实体。
/// EF Core 不允许对无键实体做 == / != 引用比较，运行时会抛：
///   Cannot translate the '==' on an expression of entity type 'MenuPowerInfo'
///   because it is a keyless entity.
/// 因此这里把"菜单授权"和"权限明细"分两次查询，在内存中用字典组合，彻底规避该限制。
/// </summary>
public class UserMenuService
{
	private readonly AppDbContext _dbContext;

	public UserMenuService(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	/// <summary>
	/// 获取指定用户所属角色的树状菜单与按钮级权限。
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

		// 3) 角色授权的菜单（RoleMenuInfo + MenuInfo 联表，两者均可正常翻译）
		var grants = await (
				from rm in _dbContext.RoleMenuInfos
				join m in _dbContext.MenuInfos on rm.MenuId equals m.MenuId
				where rm.RoleId == role.RoleId && m.State
				select new
				{
					rm.MenuId,
					rm.MenuPowerId,
					m.ParentId,
					m.ParentName,
					m.Name,
					m.Number,
					m.LevelCode,
					m.ComponentName,
					m.Icon,
					m.Url,
					m.Router,
					m.JumpUrl,
					m.Show,
					m.Close,
					m.KeepAlive,
					m.State,
					m.Description
				})
			.AsNoTracking()
			.ToListAsync();

		// 4) 权限明细单独查一次，按 MenuPowerId 建字典
		List<string> powerIds = grants
			.Select(g => g.MenuPowerId)
			.Where(id => !string.IsNullOrWhiteSpace(id))
			.Distinct()
			.ToList();

		Dictionary<string, MenuPowerInfo> powerMap = new(StringComparer.Ordinal);
		if (powerIds.Count > 0)
		{
			List<MenuPowerInfo> powerList = await _dbContext.MenuPowerInfos
				.AsNoTracking()
				.Where(p => powerIds.Contains(p.MenuPowerId))
				.ToListAsync();

			foreach (IGrouping<string, MenuPowerInfo> group in powerList.GroupBy(p => p.MenuPowerId))
			{
				powerMap[group.Key] = group.First();
			}
		}

		// 5) 内存中组合授权与权限位
		List<ResultMenuPowerInfoDto> rows = grants
			.GroupBy(g => new { g.MenuId, g.MenuPowerId })
			.Select(g =>
			{
				var grant = g.First();
				powerMap.TryGetValue(grant.MenuPowerId, out MenuPowerInfo? power);

				return new ResultMenuPowerInfoDto
				{
					MenuId = grant.MenuId,
					ParentId = grant.ParentId,
					ParentName = grant.ParentName,
					Name = grant.Name,
					Number = grant.Number,
					LevelCode = grant.LevelCode,
					ComponentName = grant.ComponentName,
					Icon = grant.Icon,
					Url = grant.Url,
					Router = grant.Router,
					JumpUrl = grant.JumpUrl,
					Show = grant.Show,
					Close = grant.Close,
					KeepAlive = grant.KeepAlive,
					State = grant.State,
					Description = grant.Description,

					MenuPowerId = grant.MenuPowerId,
					// 没有对应权限记录时，默认只允许「显示」，其余操作位为 false
					Display = power is null || power.Display,
					Insert = power is not null && power.Insert,
					Update = power is not null && power.Update,
					Delete = power is not null && power.Delete,
					Save = power is not null && (power.Save ?? false),
					Search = power is not null && (power.Search ?? false),
					Export = power is not null && (power.Export ?? false),
					Print = power is not null && (power.Print ?? false),
					Import = power is not null && (power.Import ?? false),
					Operates = power?.Operates
				};
			})
			.ToList();

		// 6) 按菜单去重：一个菜单可能挂多条权限记录，组装树前先压成"一个菜单一条"
		List<ResultMenuPowerInfoDto> menuItems = rows
			.GroupBy(x => x.MenuId)
			.Select(g => g.First())
			.OrderBy(x => x.LevelCode, StringComparer.Ordinal)
			.ToList();

		// 7) 组装两级树：一级菜单（ParentId 为空或不在结果集内）+ 其直接子菜单
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

		// 8) 权限列表：每个菜单-权限点一条，供前端控制按钮显隐
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

		// 9) 汇总
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
