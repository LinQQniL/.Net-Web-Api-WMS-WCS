using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class PickingStation
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string PickingStationD { get; set; } = null!;

    /// <summary>
    /// 站点编号
    /// </summary>
    public string? StationCode { get; set; }

    /// <summary>
    /// 生产线
    /// </summary>
    public string? Demandfrom { get; set; }

    /// <summary>
    /// 工段
    /// </summary>
    public string? DispatchingSection { get; set; }

    /// <summary>
    /// 线边储位
    /// </summary>
    public string? Bin { get; set; }

    /// <summary>
    /// Agv路线
    /// </summary>
    public string? AgvRoute { get; set; }
}
