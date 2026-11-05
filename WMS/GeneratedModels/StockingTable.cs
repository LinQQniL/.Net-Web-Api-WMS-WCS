using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库存盘点表
/// </summary>
public partial class StockingTable
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StockingTableId { get; set; } = null!;

    /// <summary>
    /// 盘点计划ID
    /// </summary>
    public string StockingPlanId { get; set; } = null!;

    /// <summary>
    /// 盘点计划名称
    /// </summary>
    public string StockingPlanName { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string Lifnr { get; set; } = null!;

    /// <summary>
    /// 供应商描述
    /// </summary>
    public string Liktx { get; set; } = null!;

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
    /// 系统库存数量（开始盘点时冻结数量）
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 实际盘点数量
    /// </summary>
    public decimal? StockingQty { get; set; }

    /// <summary>
    /// 是否已创建盘点任务
    /// </summary>
    public string? IsCreateTask { get; set; }

    /// <summary>
    /// 盘点结果状态
    /// </summary>
    public string? StockingResultState { get; set; }

    /// <summary>
    /// 盘点结果是否已上报WMS
    /// </summary>
    public string? IsCommitResult { get; set; }
}
