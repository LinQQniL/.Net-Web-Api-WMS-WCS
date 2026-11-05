using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 菜单按钮
/// </summary>
public partial class MenuInfo
{
    /// <summary>
    /// 菜单信息表ID(主键、非空)
    /// </summary>
    public string MenuId { get; set; } = null!;

    /// <summary>
    /// 父级菜单ID
    /// </summary>
    public string? ParentId { get; set; }

    /// <summary>
    /// 父级菜单名称
    /// </summary>
    public string? ParentName { get; set; }

    /// <summary>
    /// 菜单名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 编号(1：一级菜单栏2：二级菜单栏)
    /// </summary>
    public string Number { get; set; } = null!;

    /// <summary>
    /// 权限等级
    /// </summary>
    public string LevelCode { get; set; } = null!;

    /// <summary>
    /// 组件名称
    /// </summary>
    public string? ComponentName { get; set; }

    /// <summary>
    /// 图标
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// URL地址
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// 路由
    /// </summary>
    public string? Router { get; set; }

    /// <summary>
    /// 跳转地址
    /// </summary>
    public string? JumpUrl { get; set; }

    /// <summary>
    /// 是否展示
    /// </summary>
    public bool Show { get; set; }

    /// <summary>
    /// 是否关闭
    /// </summary>
    public bool Close { get; set; }

    /// <summary>
    /// 是否持活
    /// </summary>
    public bool KeepAlive { get; set; }

    /// <summary>
    /// 是否声明
    /// </summary>
    public bool State { get; set; }

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

    /// <summary>
    /// 英文名称
    /// </summary>
    public string? EnName { get; set; }

    /// <summary>
    /// 第三方语言名称
    /// </summary>
    public string? ThirdName { get; set; }
}
