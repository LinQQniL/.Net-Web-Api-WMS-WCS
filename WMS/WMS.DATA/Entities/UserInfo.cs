using System;

namespace WMS.DATA.Entities;

/// <summary>
/// 用户信息表（UserInfo）。
/// </summary>
public class UserInfo
{
	/// <summary>用户ID（主键，GUID 字符串）</summary>
	public string UserId { get; set; } = null!;

	/// <summary>所属角色ID</summary>
	public string RoleId { get; set; } = null!;

	/// <summary>登录账号</summary>
	public string UserName { get; set; } = null!;

	/// <summary>工号</summary>
	public string UserNumber { get; set; } = null!;

	/// <summary>密码（数据库中以密文存储）</summary>
	public string? Password { get; set; }

	/// <summary>显示姓名</summary>
	public string Name { get; set; } = null!;

	public string? Sex { get; set; }

	public string? Phone { get; set; }

	public string? Email { get; set; }

	public string? Address { get; set; }

	public string? Description { get; set; }

	public DateTime? LastLoginTime { get; set; }

	/// <summary>状态码（1 表示正常）</summary>
	public short StateCode { get; set; }

	public DateTime? CreateTime { get; set; }

	public DateTime? UpdateTime { get; set; }
}
