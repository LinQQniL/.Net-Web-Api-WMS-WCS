using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareDemo.Entities;

[Table("Users")]
public class User
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int Id { get; set; }

	[Required]
	[MaxLength(50)]
	public string UserName { get; set; } = string.Empty;

	[Required]
	[MaxLength(200)]
	public string Password { get; set; } = string.Empty;

	[MaxLength(50)]
	public string? Name { get; set; }

	[MaxLength(20)]
	public string? Phone { get; set; }

	[MaxLength(100)]
	public string? Email { get; set; }

	/// <summary>所属角色，空表示未分配角色（不返回任何菜单）</summary>
	public int? RoleId { get; set; }

	public bool State { get; set; } = true;

	public DateTime CreateTime { get; set; } = DateTime.Now;

	[ForeignKey(nameof(RoleId))]
	public Role? Role { get; set; }
}
