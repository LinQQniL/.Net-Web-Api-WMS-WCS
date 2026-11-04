namespace MiddlewareDemo.Models;

/// <summary>
/// 角色-菜单-权限的联表投影结果，仅服务端内部使用。
/// 字段命名与数据库 MenuInfo / MenuPowerInfo 保持一致。
/// </summary>
public class ResultMenuPowerInfoDto
{
	// ---- MenuInfo ----
	public string MenuId { get; set; } = null!;

	public string? ParentId { get; set; }

	public string? ParentName { get; set; }

	public string Name { get; set; } = null!;

	public string? Number { get; set; }

	public string LevelCode { get; set; } = null!;

	public string? ComponentName { get; set; }

	public string? Icon { get; set; }

	public string? Url { get; set; }

	public string? Router { get; set; }

	public string? JumpUrl { get; set; }

	public bool Show { get; set; }

	public bool Close { get; set; }

	public bool KeepAlive { get; set; }

	public bool State { get; set; }

	public string? Description { get; set; }

	// ---- MenuPowerInfo ----
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
