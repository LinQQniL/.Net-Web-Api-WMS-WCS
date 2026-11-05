using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 角色菜单实体
/// </summary>
public partial class RoleMenuInfo
{
    /// <summary>
    /// 角色菜单ID
    /// </summary>
    public string RoleMenuId { get; set; } = null!;

    /// <summary>
    /// 角色ID
    /// </summary>
    public string RoleId { get; set; } = null!;

    /// <summary>
    /// 菜单ID
    /// </summary>
    public string MenuId { get; set; } = null!;

    /// <summary>
    /// 菜单权限表ID
    /// </summary>
    public string MenuPowerId { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
