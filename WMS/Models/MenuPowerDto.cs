namespace MiddlewareDemo.Models;

/// <summary>
/// 单个菜单的权限位集合，供前端控制按钮级权限。
/// </summary>
public class MenuPowerDto
{
	public string MenuId { get; set; } = null!;

	public string MenuPowerId { get; set; } = null!;

	public bool Display { get; set; }

	public bool Insert { get; set; }

	public bool Update { get; set; }

	public bool Delete { get; set; }

	public bool Save { get; set; }

	public bool Search { get; set; }

	public bool Export { get; set; }

	public bool Print { get; set; }

	public bool Import { get; set; }

	public string? Operates { get; set; }
}
