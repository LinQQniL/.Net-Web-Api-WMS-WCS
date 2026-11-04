using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 角色-菜单授权关系表（多对多），权限位内联在这一行上
/// </summary>
[Table("RoleMenus")]
public class RoleMenu
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	public int RoleId { get; set; }

	public int MenuId { get; set; }

	/// <summary>显示</summary>
	public bool Display { get; set; } = true;

	/// <summary>新增</summary>
	public bool Insert { get; set; }

	/// <summary>修改</summary>
	public bool Update { get; set; }

	/// <summary>删除</summary>
	public bool Delete { get; set; }

	/// <summary>保存</summary>
	public bool Save { get; set; }

	/// <summary>查询</summary>
	public bool Search { get; set; }

	/// <summary>导出</summary>
	public bool Export { get; set; }

	/// <summary>打印</summary>
	public bool Print { get; set; }

	/// <summary>导入</summary>
	public bool Import { get; set; }

	/// <summary>自定义操作位（逗号分隔）</summary>
	[MaxLength(500)]
	public string? Operates { get; set; }

	public DateTime CreateTime { get; set; } = DateTime.Now;

	[ForeignKey(nameof(RoleId))]
	public Role? Role { get; set; }

	[ForeignKey(nameof(MenuId))]
	public Menu? Menu { get; set; }
}
