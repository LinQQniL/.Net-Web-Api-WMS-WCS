using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiddlewareDemo.Data;
using MiddlewareDemo.Entities;
using MiddlewareDemo.Helper;
using MiddlewareDemo.Models;

namespace MiddlewareDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class MenuController : ControllerBase
{
	private readonly AppDbContext _dbContext;

	public MenuController(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	[HttpGet("tree")]
	public async Task<IActionResult> GetMenuTree()
	{
		List<MenuDto> tree = BuildTree(await _dbContext.Menus.OrderBy((Menu m) => m.SortOrder).ToListAsync());
		return Ok(tree);
	}

	[HttpGet("list")]
	public async Task<IActionResult> GetMenuList([FromQuery] string? name, [FromQuery] int page = 1, [FromQuery] int pageSize = 50)
	{
		IQueryable<Menu> query = _dbContext.Menus.AsQueryable();
		if (!string.IsNullOrWhiteSpace(name))
		{
			query = query.Where((Menu m) => m.Name.Contains(name));
		}
		return Ok(new
		{
			total = await query.CountAsync(),
			page = page,
			pageSize = pageSize,
			items = await (from m in query.OrderBy((Menu m) => m.SortOrder).Skip((page - 1) * pageSize).Take(pageSize)
				select new MenuDto
				{
					Id = m.Id,
					Name = m.Name,
					Path = m.Path,
					Icon = m.Icon,
					ComponentName = m.ComponentName,
					Show = m.Show,
					KeepAlive = m.KeepAlive,
					Close = m.Close,
					State = m.State,
					Description = m.Description
				}).ToListAsync()
		});
	}

	[HttpGet("{id}")]
	public async Task<IActionResult> GetMenu(int id)
	{
		Menu menu = await _dbContext.Menus.FindAsync(id);
		if (menu == null)
		{
			return NotFound(new
			{
				message = "菜单不存在"
			});
		}
		return Ok(new MenuDto
		{
			Id = menu.Id,
			Name = menu.Name,
			Path = menu.Path,
			Icon = menu.Icon,
			ComponentName = menu.ComponentName,
			Show = menu.Show,
			KeepAlive = menu.KeepAlive,
			Close = menu.Close,
			State = menu.State,
			Description = menu.Description
		});
	}

	[HttpGet("parents")]
	public async Task<IActionResult> GetParentMenus()
	{
		return Ok(await (from m in _dbContext.Menus
			where m.ParentId == (int?)null
			orderby m.SortOrder
			select new { m.Id, m.Name, m.Icon }).ToListAsync());
	}

	[HttpPost]
	public async Task<IActionResult> AddMenu([FromBody] MenuManageDto dto)
	{
		if (dto.ParentId.HasValue && await _dbContext.Menus.FindAsync(dto.ParentId.Value) == null)
		{
			return BadRequest(new
			{
				message = "父菜单不存在"
			});
		}
		Menu menu = new Menu
		{
			ParentId = dto.ParentId,
			Name = dto.Name,
			Path = dto.Path,
			Icon = dto.Icon,
			SortOrder = dto.SortOrder,
			ComponentName = dto.ComponentName,
			Show = dto.Show,
			KeepAlive = dto.KeepAlive,
			Close = dto.Close,
			State = dto.State,
			Description = dto.Description,
			CreateTime = DateTime.Now
		};
		_dbContext.Menus.Add(menu);
		await _dbContext.SaveChangesAsync();
		Logger.Info($"新增菜单: Id={menu.Id}, Name={menu.Name}");
		return Ok(new
		{
			message = "新增成功",
			id = menu.Id
		});
	}

	[HttpPut("{id}")]
	public async Task<IActionResult> UpdateMenu(int id, [FromBody] MenuManageDto dto)
	{
		Menu menu = await _dbContext.Menus.FindAsync(id);
		if (menu == null)
		{
			return NotFound(new
			{
				message = "菜单不存在"
			});
		}
		if (dto.ParentId == id)
		{
			return BadRequest(new
			{
				message = "不能将菜单设为自己的子菜单"
			});
		}
		menu.ParentId = dto.ParentId;
		menu.Name = dto.Name;
		menu.Path = dto.Path;
		menu.Icon = dto.Icon;
		menu.SortOrder = dto.SortOrder;
		menu.ComponentName = dto.ComponentName;
		menu.Show = dto.Show;
		menu.KeepAlive = dto.KeepAlive;
		menu.Close = dto.Close;
		menu.State = dto.State;
		menu.Description = dto.Description;
		await _dbContext.SaveChangesAsync();
		Logger.Info($"更新菜单: Id={menu.Id}, Name={menu.Name}");
		return Ok(new
		{
			message = "更新成功"
		});
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteMenu(int id)
	{
		Menu menu = await _dbContext.Menus.FindAsync(id);
		if (menu == null)
		{
			return NotFound(new
			{
				message = "菜单不存在"
			});
		}
		List<Menu> childMenus = await _dbContext.Menus.Where((Menu m) => m.ParentId == (int?)id).ToListAsync();
		_dbContext.Menus.RemoveRange(childMenus);
		_dbContext.Menus.Remove(menu);
		await _dbContext.SaveChangesAsync();
		Logger.Info($"删除菜单: Id={menu.Id}, Name={menu.Name}, 子菜单数={childMenus.Count}");
		return Ok(new
		{
			message = "删除成功",
			deletedChildren = childMenus.Count
		});
	}

	[HttpPatch("{id}/toggle")]
	public async Task<IActionResult> ToggleMenuState(int id)
	{
		Menu menu = await _dbContext.Menus.FindAsync(id);
		if (menu == null)
		{
			return NotFound(new
			{
				message = "菜单不存在"
			});
		}
		menu.State = !menu.State;
		await _dbContext.SaveChangesAsync();
		Logger.Info($"切换菜单状态: Id={menu.Id}, Name={menu.Name}, State={menu.State}");
		return Ok(new
		{
			message = (menu.State ? "已启用" : "已禁用"),
			state = menu.State
		});
	}

	private List<MenuDto> BuildTree(List<Menu> allMenus)
	{
		List<Menu> source = allMenus.Where((Menu m) => !m.ParentId.HasValue).ToList();
		return source.Select((Menu parent) => new MenuDto
		{
			Id = parent.Id,
			Name = parent.Name,
			Path = parent.Path,
			Icon = parent.Icon,
			ComponentName = parent.ComponentName,
			Show = parent.Show,
			KeepAlive = parent.KeepAlive,
			Close = parent.Close,
			State = parent.State,
			Description = parent.Description,
			Children = BuildChildren(allMenus, parent.Id)
		}).ToList();
	}

	private List<MenuDto> BuildChildren(List<Menu> allMenus, int parentId)
	{
		return (from child in allMenus
			where child.ParentId == parentId
			select new MenuDto
			{
				Id = child.Id,
				Name = child.Name,
				Path = child.Path,
				Icon = child.Icon,
				ComponentName = child.ComponentName,
				Show = child.Show,
				KeepAlive = child.KeepAlive,
				Close = child.Close,
				State = child.State,
				Description = child.Description,
				Children = BuildChildren(allMenus, child.Id)
			}).ToList();
	}
}
