using System.Collections.Generic;

namespace MiddlewareDemo.Models;

public class MenuDto
{
	public int Id { get; set; }

	public string Name { get; set; } = string.Empty;

	public string Path { get; set; } = string.Empty;

	public string? Icon { get; set; }

	public string? ComponentName { get; set; }

	public bool Show { get; set; } = true;

	public bool KeepAlive { get; set; } = false;

	public bool Close { get; set; } = true;

	public bool State { get; set; } = true;

	public string? Description { get; set; }

	public List<MenuDto>? Children { get; set; }
}
