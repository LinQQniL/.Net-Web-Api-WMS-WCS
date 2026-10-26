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

	public DateTime CreateTime { get; set; } = DateTime.Now;
}
