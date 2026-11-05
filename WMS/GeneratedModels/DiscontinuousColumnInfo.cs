using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 料箱库有阻挡列设置表
/// </summary>
public partial class DiscontinuousColumnInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string DiscontinuousColumnInfoId { get; set; } = null!;

    /// <summary>
    /// 巷道开始
    /// </summary>
    public int LaneStart { get; set; }

    /// <summary>
    /// 巷道结束
    /// </summary>
    public int LaneEnd { get; set; }

    /// <summary>
    /// 行开始
    /// </summary>
    public int RowStart { get; set; }

    /// <summary>
    /// 行结束
    /// </summary>
    public int RowEnd { get; set; }

    /// <summary>
    /// 层开始
    /// </summary>
    public int LayerStart { get; set; }

    /// <summary>
    /// 层结束
    /// </summary>
    public int LayerEnd { get; set; }

    /// <summary>
    /// 列号
    /// </summary>
    public int DiscontinuousColumn { get; set; }
}
