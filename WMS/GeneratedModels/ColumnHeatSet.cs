using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 列热度设置表
/// </summary>
public partial class ColumnHeatSet
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string ColumnInfoId { get; set; } = null!;

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string WarehouseCode { get; set; } = null!;

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 层开始
    /// </summary>
    public short? LayerStart { get; set; }

    /// <summary>
    /// 层结束
    /// </summary>
    public short? LayerEnd { get; set; }

    /// <summary>
    /// 列开始
    /// </summary>
    public short? ColumnStart { get; set; }

    /// <summary>
    /// 列结束
    /// </summary>
    public short? ColumnEnd { get; set; }

    /// <summary>
    /// 热度值
    /// </summary>
    public short ColumnHeat { get; set; }
}
