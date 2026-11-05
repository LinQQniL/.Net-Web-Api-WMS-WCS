using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MiddlewareDemo.Auth;
using MiddlewareDemo.Data;
using MiddlewareDemo.Entities;
using MiddlewareDemo.Helper;
using MiddlewareDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MiddlewareDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
	private readonly TokenHelper _tokenHelper;

	private readonly JwtSettings _jwtSettings;

	private readonly AppDbContext _dbContext;

	public AuthController(TokenHelper tokenHelper, IOptions<JwtSettings> jwtSettings, AppDbContext dbContext)
	{
		_tokenHelper = tokenHelper;
		_jwtSettings = jwtSettings.Value;
		_dbContext = dbContext;
	}

	[HttpPost("login")]
	public async Task<IActionResult> Login([FromBody] LoginRequest request)
	{
		Logger.Info("登录请求: 用户名=" + request.UserName);
		User user = await _dbContext.Users.FirstOrDefaultAsync((User u) => u.UserName == request.UserName && u.Password == request.Password);
		if (user != null)
		{
			string token = _tokenHelper.GenerateToken(user.Id.ToString(), user.UserName);
			Logger.Info("登录成功: " + request.UserName);
			return Ok(new LoginResponse
			{
				Token = token,
				TokenType = "Bearer",
				ExpiresIn = _jwtSettings.ExpireMinutes * 60
			});
		}
		Logger.Warn("登录失败: " + request.UserName + " 用户名或密码错误");
		return Unauthorized(new
		{
			message = "用户名或密码错误"
		});
	}

	[HttpGet("profile")]
	[Authorize]
	public IActionResult GetProfile()
	{
		string userId = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
		string userName = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;
		return Ok(new
		{
			userId = userId,
			userName = userName,
			message = "你已通过认证，这是受保护的数据"
		});
	}

	[HttpGet("menus")]
	[Authorize]
	public async Task<IActionResult> GetMenus()
	{


        try
        {
            string? userId = _Dentity.GetUserId();
            var result = await _RoleMenu.ShowUserMenuAsync(userId);
            return Info(result, "用户所属角色的树状菜单权限获取成功");
        }
        catch (Exception ex)
        {
            return Error<ResultUserMenuDto>(ex.Message);
        }


  //      List<Menu> allMenus = await (from m in _dbContext.Menus  --这是原代码
		//	where m.State
		//	orderby m.SortOrder
		//	select m).ToListAsync();
		//List<Menu> topLevel = allMenus.Where((Menu m) => !m.ParentId.HasValue).ToList();
		//List<MenuDto> result = topLevel.Select((Menu parent) => new MenuDto
		//{
		//	Id = parent.Id,
		//	Name = parent.Name,
		//	Path = parent.Path,
		//	Icon = parent.Icon,
		//	ComponentName = parent.ComponentName,
		//	Show = parent.Show,
		//	KeepAlive = parent.KeepAlive,
		//	Close = parent.Close,
		//	State = parent.State,
		//	Description = parent.Description,
		//	Children = (from child in allMenus
		//		where child.ParentId == parent.Id
		//		select new MenuDto
		//		{
		//			Id = child.Id,
		//			Name = child.Name,
		//			Path = child.Path,
		//			Icon = child.Icon,
		//			ComponentName = child.ComponentName,
		//			Show = child.Show,
		//			KeepAlive = child.KeepAlive,
		//			Close = child.Close,
		//			State = child.State,
		//			Description = child.Description
		//		}).ToList()
		//}).ToList();
		//return Ok(result);
	}
}
