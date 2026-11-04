using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 托盘库大托盘列设置表
/// </summary>
public partial class BigTrayColumnInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string BigTrayColumnInfoId { get; set; } = null!;

    /// <summary>
    /// 巷道编号
    /// </summary>
    public string? LaneCode { get; set; }

    /// <summary>
    /// 行开始
    /// </summary>
    public int? RowStart { get; set; }

    /// <summary>
    /// 行结束
    /// </summary>
    public int? RowEnd { get; set; }

    /// <summary>
    /// 层开始
    /// </summary>
    public int? LayerStart { get; set; }

    /// <summary>
    /// 层结束
    /// </summary>
    public int? LayerEnd { get; set; }

    /// <summary>
    /// 列号
    /// </summary>
    public int? BigTrayColumn { get; set; }
}
