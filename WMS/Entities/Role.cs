using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 角色表：用户归属于角色，角色决定可见菜单与操作权限
/// </summary>
[Table("Roles")]
public class Role
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	/// <summary>角色编码，唯一，用于程序内判断（如 Admin、Warehouse）</summary>
	[Required]
	[MaxLength(50)]
	public string Code { get; set; } = string.Empty;

	/// <summary>角色显示名称</summary>
	[Required]
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;

	[MaxLength(200)]
	public string? Description { get; set; }

	public bool State { get; set; } = true;

	public DateTime CreateTime { get; set; } = DateTime.Now;

	/// <summary>该角色下的用户</summary>
	public List<User> Users { get; set; } = new();

	/// <summary>该角色授权的菜单</summary>
	public List<RoleMenu> RoleMenus { get; set; } = new();
}
