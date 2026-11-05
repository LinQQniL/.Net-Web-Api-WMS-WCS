using System;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 角色信息表（对应数据库表 RoleInfo）
/// </summary>
public class RoleInfo
{
	/// <summary>角色ID（主键，GUID 字符串）</summary>
	public string RoleId { get; set; } = null!;

	/// <summary>角色代码</summary>
	public string Code { get; set; } = null!;

	/// <summary>角色名称</summary>
	public string Name { get; set; } = null!;

	public string? Description { get; set; }

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }
}
