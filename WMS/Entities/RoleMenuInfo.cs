using System;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 角色菜单关联表（对应数据库表 RoleMenuInfo）。
/// 该表在数据库中没有主键，EF 以 HasNoKey 映射。
/// </summary>
public class RoleMenuInfo
{
	/// <summary>角色菜单ID</summary>
	public string RoleMenuId { get; set; } = null!;

	/// <summary>角色ID</summary>
	public string RoleId { get; set; } = null!;

	/// <summary>菜单ID</summary>
	public string MenuId { get; set; } = null!;

	/// <summary>菜单权限ID</summary>
	public string MenuPowerId { get; set; } = null!;

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }
}
