namespace MiddlewareDemo.Models;

public class MenuManageDto
{
	public int? Id { get; set; }

	public int? ParentId { get; set; }

	public string Name { get; set; } = string.Empty;

	public string Path { get; set; } = string.Empty;

	public string? Icon { get; set; }

	public int SortOrder { get; set; }

	public string? ComponentName { get; set; }

	public bool Show { get; set; } = true;

	public bool KeepAlive { get; set; } = false;

	public bool Close { get; set; } = true;

	public bool State { get; set; } = true;

	public string? Description { get; set; }
}
