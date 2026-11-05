using System;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 菜单权限表（对应数据库表 MenuPowerInfo）。
/// 该表在数据库中没有主键，EF 以 HasNoKey 映射，只能查询不能追踪更新。
/// </summary>
public class MenuPowerInfo
{
	/// <summary>菜单权限ID</summary>
	public string MenuPowerId { get; set; } = null!;

	/// <summary>菜单ID</summary>
	public string MenuId { get; set; } = null!;

	/// <summary>显示权限</summary>
	public bool Display { get; set; }

	/// <summary>添加权限</summary>
	public bool Insert { get; set; }

	/// <summary>修改权限</summary>
	public bool Update { get; set; }

	/// <summary>删除权限</summary>
	public bool Delete { get; set; }

	public bool? Save { get; set; }

	public bool? Search { get; set; }

	public bool? Export { get; set; }

	public bool? Print { get; set; }

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }

	/// <summary>自定义操作权限</summary>
	public string? Operates { get; set; }

	public bool? Import { get; set; }
}
