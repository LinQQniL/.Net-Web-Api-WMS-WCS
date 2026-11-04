using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 自定义路径表
/// </summary>
public partial class RouteStationInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 站点码
    /// </summary>
    public string? StationId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 站点类型
    /// </summary>
    public int? StationType { get; set; }

    /// <summary>
    /// 可以到达站点码
    /// </summary>
    public string? MidStationId { get; set; }

    /// <summary>
    /// 虚拟站点码
    /// </summary>
    public string? VitStationId { get; set; }

    /// <summary>
    /// 预留字段1
    /// </summary>
    public string? Field1 { get; set; }

    /// <summary>
    /// 预留字段2
    /// </summary>
    public string? Field2 { get; set; }

    /// <summary>
    /// 预留字段3
    /// </summary>
    public string? Field3 { get; set; }

    /// <summary>
    /// 预留字段4
    /// </summary>
    public string? Field4 { get; set; }

    /// <summary>
    /// 预留字段5
    /// </summary>
    public string? Field5 { get; set; }
}
