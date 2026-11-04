using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 热度设置表
/// </summary>
public partial class HeatSet
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string HeatSetId { get; set; } = null!;

    /// <summary>
    /// 层开始
    /// </summary>
    public int LayerStart { get; set; }

    /// <summary>
    /// 层结束
    /// </summary>
    public int LayerEnd { get; set; }

    /// <summary>
    /// 列开始
    /// </summary>
    public int ColumnStart { get; set; }

    /// <summary>
    /// 列结束
    /// </summary>
    public int ColumnEnd { get; set; }

    /// <summary>
    /// 热度值
    /// </summary>
    public int Heat { get; set; }

    /// <summary>
    /// 区域编码
    /// </summary>
    public string AreaCode { get; set; } = null!;

    /// <summary>
    /// 仓库编码
    /// </summary>
    public string WarehouseCode { get; set; } = null!;
}
