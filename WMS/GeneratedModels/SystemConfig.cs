using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 系统配置表
/// </summary>
public partial class SystemConfig
{
    /// <summary>
    /// 系统配置ID
    /// </summary>
    public string SystemConfigId { get; set; } = null!;

    /// <summary>
    /// 配置编码
    /// </summary>
    public string ConfigCode { get; set; } = null!;

    /// <summary>
    /// 配置名称
    /// </summary>
    public string ConfigName { get; set; } = null!;

    /// <summary>
    /// 配置值
    /// </summary>
    public string ConfigValue { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }
}
