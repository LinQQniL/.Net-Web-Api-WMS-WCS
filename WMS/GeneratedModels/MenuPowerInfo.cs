using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 菜单权限实体
/// </summary>
public partial class MenuPowerInfo
{
    /// <summary>
    /// 菜单权限表ID
    /// </summary>
    public string MenuPowerId { get; set; } = null!;

    /// <summary>
    /// 菜单ID
    /// </summary>
    public string MenuId { get; set; } = null!;

    /// <summary>
    /// 显示权限
    /// </summary>
    public bool Display { get; set; }

    /// <summary>
    /// 添加权限
    /// </summary>
    public bool Insert { get; set; }

    /// <summary>
    /// 修改权限
    /// </summary>
    public bool Update { get; set; }

    /// <summary>
    /// 删除权限
    /// </summary>
    public bool Delete { get; set; }

    /// <summary>
    /// 保存权限
    /// </summary>
    public bool? Save { get; set; }

    /// <summary>
    /// 检索权限
    /// </summary>
    public bool? Search { get; set; }

    /// <summary>
    /// 导出权限
    /// </summary>
    public bool? Export { get; set; }

    /// <summary>
    /// 打印权限
    /// </summary>
    public bool? Print { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 操作权限
    /// </summary>
    public string? Operates { get; set; }

    /// <summary>
    /// 导入权限
    /// </summary>
    public bool? Import { get; set; }
}
