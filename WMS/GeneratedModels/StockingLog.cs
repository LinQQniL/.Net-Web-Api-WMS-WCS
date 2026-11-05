using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库存盘点日志
/// </summary>
public partial class StockingLog
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StockingLogId { get; set; } = null!;

    /// <summary>
    /// 盘点计划ID
    /// </summary>
    public string StockingPlanId { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string Lifnr { get; set; } = null!;

    /// <summary>
    /// 供应商描述
    /// </summary>
    public string? Liktx { get; set; }

    /// <summary>
    /// 装配工位
    /// </summary>
    public string? UrnPackStation { get; set; }

    /// <summary>
    /// 物料号
    /// </summary>
    public string Matnr { get; set; } = null!;

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 箱号
    /// </summary>
    public string? ContainerCode { get; set; }

    /// <summary>
    /// 系统库存数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 实际盘点数量
    /// </summary>
    public decimal? StockingQty { get; set; }

    /// <summary>
    /// 盘点结果状态
    /// </summary>
    public string? StockingResultState { get; set; }

    /// <summary>
    /// 盘点人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 盘点时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// BYD仓库号
    /// </summary>
    public string? WhNumber { get; set; }
}
