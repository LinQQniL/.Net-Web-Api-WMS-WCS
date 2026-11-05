using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 角色信息表
/// </summary>
public partial class RoleInfo
{
    /// <summary>
    /// 角色信息表ID（主键、非空）
    /// </summary>
    public string RoleId { get; set; } = null!;

    /// <summary>
    /// 角色代码
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 角色名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
