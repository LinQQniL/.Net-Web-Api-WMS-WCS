using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Data;
using WMS.DATA.Entities;

namespace MiddlewareDemo.Controllers;

/// <summary>
/// 临时诊断接口：排查"登录成功但菜单为空"的问题。
/// 定位完成后应删除本文件。
/// </summary>
[ApiController]
[Route("api/[controller]")]
[AllowAnonymous]
public class DebugController : ControllerBase
{
	private readonly AppDbContext _db;

	public DebugController(AppDbContext db)
	{
		_db = db;
	}

	[HttpGet("menus")]
	public async Task<IActionResult> Diagnose()
	{
		try
		{
			var users = await _db.UserInfos
				.AsNoTracking()
				.Select(u => new { u.UserId, u.UserName, u.RoleId, u.StateCode })
				.Take(20)
				.ToListAsync();

			var roleIdsInGrants = await _db.RoleMenuInfos
				.AsNoTracking()
				.Select(r => r.RoleId)
				.Distinct()
				.ToListAsync();

			var menuStats = await _db.MenuInfos
				.AsNoTracking()
				.GroupBy(m => m.State)
				.Select(g => new { State = g.Key, Count = g.Count() })
				.ToListAsync();

			var menuCount = await _db.MenuInfos.CountAsync();
			var grantCount = await _db.RoleMenuInfos.CountAsync();
			var powerCount = await _db.MenuPowerInfos.CountAsync();

			// 复现服务的联表查询，看能取到几条
			var joinCount = await (
				from rm in _db.RoleMenuInfos
				join m in _db.MenuInfos on rm.MenuId equals m.MenuId
				select rm.MenuId).CountAsync();

			var joinStateCount = await (
				from rm in _db.RoleMenuInfos
				join m in _db.MenuInfos on rm.MenuId equals m.MenuId
				where m.State
				select rm.MenuId).CountAsync();

			return Ok(new
			{
				users,
				roleIdsInGrants,
				menuStats,
				counts = new { menuCount, grantCount, powerCount, joinCount, joinStateCount }
			});
		}
		catch (Exception ex)
		{
			return Ok(new { error = ex.Message, stack = ex.ToString() });
		}
	}
}
