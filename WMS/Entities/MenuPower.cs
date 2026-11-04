using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 菜单可用的权限点字典（如 查看/新增/删除），
/// 与 RoleMenus 上的布尔位配合，供前端渲染按钮级权限。
/// </summary>
[Table("MenuPowers")]
public class MenuPower
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int MenuPowerId { get; set; }

	public int MenuId { get; set; }

	/// <summary>权限编码，如 view / insert / delete</summary>
	[Required]
	[MaxLength(50)]
	public string Code { get; set; } = string.Empty;

	/// <summary>权限显示名称</summary>
	[Required]
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;

	[MaxLength(200)]
	public string? Description { get; set; }

	public int SortOrder { get; set; }

	public DateTime CreateTime { get; set; } = DateTime.Now;

	[ForeignKey(nameof(MenuId))]
	public Menu? Menu { get; set; }
}
