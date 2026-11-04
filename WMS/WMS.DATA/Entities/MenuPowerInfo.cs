using System;

namespace WMS.DATA.Entities;

/// <summary>
/// 菜单权限表（MenuPowerInfo）。数据库中无主键，EF 以 HasNoKey 映射，只读查询。
/// </summary>
public class MenuPowerInfo
{
	/// <summary>菜单权限ID</summary>
	public string MenuPowerId { get; set; } = null!;

	/// <summary>菜单ID</summary>
	public string MenuId { get; set; } = null!;

	public bool Display { get; set; }

	public bool Insert { get; set; }

	public bool Update { get; set; }

	public bool Delete { get; set; }

	public bool? Save { get; set; }

	public bool? Search { get; set; }

	public bool? Export { get; set; }

	public bool? Print { get; set; }

	public bool? Import { get; set; }

	/// <summary>自定义操作权限</summary>
	public string? Operates { get; set; }

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }
}
