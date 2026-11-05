using System;

namespace MiddlewareDemo.Entities;

/// <summary>
/// 菜单信息表（对应数据库表 MenuInfo）
/// </summary>
public class MenuInfo
{
	/// <summary>菜单ID（主键，GUID 字符串）</summary>
	public string MenuId { get; set; } = null!;

	/// <summary>父级菜单ID</summary>
	public string? ParentId { get; set; }

	/// <summary>父级菜单名称</summary>
	public string? ParentName { get; set; }

	/// <summary>菜单名称</summary>
	public string Name { get; set; } = null!;

	/// <summary>编号（1：一级菜单栏 2：二级菜单栏）</summary>
	public string Number { get; set; } = null!;

	/// <summary>权限等级</summary>
	public string LevelCode { get; set; } = null!;

	/// <summary>组件名称</summary>
	public string? ComponentName { get; set; }

	public string? Icon { get; set; }

	/// <summary>URL 地址</summary>
	public string? Url { get; set; }

	/// <summary>路由</summary>
	public string? Router { get; set; }

	/// <summary>跳转地址</summary>
	public string? JumpUrl { get; set; }

	public bool Show { get; set; }

	public bool Close { get; set; }

	public bool KeepAlive { get; set; }

	public bool State { get; set; }

	public string? Description { get; set; }

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }

	public string? EnName { get; set; }

	public string? ThirdName { get; set; }
}
