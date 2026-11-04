using System.Collections.Generic;

namespace MiddlewareDemo.Models;

/// <summary>
/// 树状菜单节点，字段与数据库 MenuInfo 对齐。
/// </summary>
public class MenusDto
{
	public string MenuId { get; set; } = null!;

	public string? ParentId { get; set; }

	public string? ParentName { get; set; }

	public string Name { get; set; } = null!;

	/// <summary>编号（1：一级菜单栏 2：二级菜单栏）</summary>
	public string? Number { get; set; }

	/// <summary>层级编码，用于排序</summary>
	public string LevelCode { get; set; } = null!;

	public string? ComponentName { get; set; }

	public string? Icon { get; set; }

	/// <summary>后端路由地址</summary>
	public string? Url { get; set; }

	/// <summary>前端路由地址</summary>
	public string? Router { get; set; }

	/// <summary>外部跳转地址</summary>
	public string? JumpUrl { get; set; }

	public bool Show { get; set; }

	public bool Close { get; set; }

	public bool KeepAlive { get; set; }

	public bool State { get; set; }

	public string? Description { get; set; }

	public List<MenusDto> children { get; set; } = new();
}
