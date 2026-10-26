using System;
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
}
