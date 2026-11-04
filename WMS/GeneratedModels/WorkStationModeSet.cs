using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 站台可切换模式
/// </summary>
public partial class WorkStationModeSet
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string WorkStationModeSetId { get; set; } = null!;

    /// <summary>
    /// 站点编号
    /// </summary>
    public string StationCode { get; set; } = null!;

    /// <summary>
    /// 支持模式
    /// </summary>
    public string CanChangeMode { get; set; } = null!;
}
