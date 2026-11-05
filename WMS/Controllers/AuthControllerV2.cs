using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MiddlewareDemo.Auth;
using MiddlewareDemo.Data;
using MiddlewareDemo.Helper;
using MiddlewareDemo.Models;
using MiddlewareDemo.Services;
using WMS.DATA.Entities;

namespace MiddlewareDemo.Controllers;

/// <summary>
/// 认证与菜单授权接口（AuthControllerV2）。
/// 数据源为数据库真实表 UserInfo / RoleInfo / MenuInfo 等。
/// 相比旧版，返回菜单时会把 Ant Design 图标名转换成 Element Plus 图标名。
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
	private readonly TokenHelper _tokenHelper;
	private readonly JwtSettings _jwtSettings;
	private readonly AppDbContext _dbContext;
	private readonly UserMenuService _userMenuService;

	public AuthController(
		TokenHelper tokenHelper,
		IOptions<JwtSettings> jwtSettings,
		AppDbContext dbContext,
		UserMenuService userMenuService)
	{
		_tokenHelper = tokenHelper;
		_jwtSettings = jwtSettings.Value;
		_dbContext = dbContext;
		_userMenuService = userMenuService;
	}

	/// <summary>
	/// 登录接口
	/// POST /api/auth/login
	/// </summary>
	[HttpPost("login")]
	public async Task<IActionResult> Login([FromBody] LoginRequest request)
	{
		Logger.Info($"登录请求: 用户名={request.UserName}");

		// 按账号 + 密码查询用户（UserInfo.UserName 为登录账号）
		UserInfo? user = await _dbContext.UserInfos
			.FirstOrDefaultAsync(u => u.UserName == request.UserName && u.Password == request.Password);

		if (user is null)
		{
			Logger.Warn($"登录失败: {request.UserName} 用户名或密码错误");
			return Unauthorized(new { message = "用户名或密码错误" });
		}

		if (user.StateCode != 1)
		{
			Logger.Warn($"登录失败: {request.UserName} 账号已停用(StateCode={user.StateCode})");
			return Unauthorized(new { message = "账号已被停用，请联系管理员" });
		}

		string token = _tokenHelper.GenerateToken(user.UserId, user.UserName);

		// 记录最后登录时间
		user.LastLoginTime = DateTime.Now;
		try
		{
			await _dbContext.SaveChangesAsync();
		}
		catch (Exception ex)
		{
			// 登录时间写入失败不应影响登录本身
			Logger.Error("更新最后登录时间失败", ex);
		}

		Logger.Info($"登录成功: {request.UserName}");

		return Ok(new LoginResponse
		{
			Token = token,
			TokenType = "Bearer",
			ExpiresIn = _jwtSettings.ExpireMinutes * 60
		});
	}

	/// <summary>
	/// 获取当前用户信息（需要 Token）
	/// GET /api/auth/profile
	/// </summary>
	[HttpGet("profile")]
	[Authorize]
	public IActionResult GetProfile()
	{
		string? userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
		string? userName = User.FindFirst(ClaimTypes.Name)?.Value;

		return Ok(new
		{
			userId,
			userName,
			message = "你已通过认证，这是受保护的数据"
		});
	}

	/// <summary>
	/// 获取当前登录用户的树状菜单（需要 Token）
	///
	/// 返回纯数组，字段与前端 stores/auth.js、router 约定一致：
	/// [{ id, name, path, icon, componentName, show, keepAlive, close, state, description, children }]
	///
	/// icon 字段：数据库 MenuInfo.Icon 存的是 Ant Design 图标名（HomeOutlined 等），
	/// 前端使用 Element Plus 图标库（House 等），这里统一转换。
	/// GET /api/auth/menus
	/// </summary>
	[HttpGet("menus")]
	[Authorize]
	public async Task<IActionResult> GetMenus()
	{
		try
		{
			// 当前登录用户 Id 直接取自 JWT，不信任前端传入
			string? userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			ResultUserMenuDto result = await _userMenuService.ShowUserMenuAsync(userId);
			return Ok(result.Menus.Select(ToFrontendMenu).ToList());
		}
		catch (Exception ex)
		{
			Logger.Error("获取用户菜单失败", ex);
			// 前端此时只需空菜单即可，不阻断页面
			return Ok(new List<object>());
		}
	}

	/// <summary>
	/// 把内部树节点转成前端约定的字段结构
	/// </summary>
	private static object ToFrontendMenu(MenusDto m)
	{
		return new
		{
			id = m.MenuId,
			name = m.Name,
			// 前端以 path 作为路由键，优先取前端路由
			path = m.Router ?? m.Url,
			// Ant Design 名 -> Element Plus 名
			icon = IconNameMapper.ToElementPlus(m.Icon),
			componentName = m.ComponentName,
			show = m.Show,
			keepAlive = m.KeepAlive,
			close = m.Close,
			state = m.State,
			description = m.Description,
			children = m.children.Select(ToFrontendMenu).ToList()
		};
	}
}
