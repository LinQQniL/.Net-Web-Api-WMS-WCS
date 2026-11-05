using System;

namespace WMS.DATA.Entities;

/// <summary>
/// 角色菜单关联表（RoleMenuInfo）。数据库中无主键，EF 以 HasNoKey 映射。
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
