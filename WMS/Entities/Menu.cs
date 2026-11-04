using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareDemo.Entities;

[Table("Menus")]
public class Menu
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	public int? ParentId { get; set; }

	[Required]
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;

	[Required]
	[MaxLength(200)]
	public string Path { get; set; } = string.Empty;

	[MaxLength(50)]
	public string? Icon { get; set; }

	public int SortOrder { get; set; }

	[MaxLength(100)]
	public string? ComponentName { get; set; }

	public bool Show { get; set; } = true;

	public bool KeepAlive { get; set; } = false;

	public bool Close { get; set; } = true;

	public bool State { get; set; } = true;

	[MaxLength(200)]
	public string? Description { get; set; }

	public DateTime CreateTime { get; set; } = DateTime.Now;

	/// <summary>层级编码，用于同级排序与树形展示（如 1、1.1、1.1.1）</summary>
	[MaxLength(50)]
	public string? LevelCode { get; set; }

	/// <summary>父级菜单名称，冗余字段，减少前端请求</summary>
	[MaxLength(50)]
	public string? ParentName { get; set; }

	/// <summary>该菜单下的角色授权记录</summary>
	public List<RoleMenu> RoleMenus { get; set; } = new();

	/// <summary>该菜单下的权限点</summary>
	public List<MenuPower> MenuPowers { get; set; } = new();
}
