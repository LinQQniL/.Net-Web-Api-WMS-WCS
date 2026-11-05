using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 监控布局信息表
/// </summary>
public partial class MonitorInfo
{
    /// <summary>
    /// 监控页面配置表ID
    /// </summary>
    public string MonitorId { get; set; } = null!;

    public string? ProgramCode { get; set; }

    /// <summary>
    /// 监控页面名称
    /// </summary>
    public string MonitorName { get; set; } = null!;

    public string? Description { get; set; }

    public string? ProgramUrl { get; set; }

    /// <summary>
    /// 监控配置信息
    /// </summary>
    public string? Data { get; set; }

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
