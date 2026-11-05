using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库存盘点计划表
/// </summary>
public partial class StockingPlan
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StockingPlanId { get; set; } = null!;

    /// <summary>
    /// 计划名称
    /// </summary>
    public string StockingPlanName { get; set; } = null!;

    /// <summary>
    /// 盘点类型
    /// </summary>
    public string StockingType { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 计划开始时间
    /// </summary>
    public DateTime? PlanBeginTime { get; set; }

    /// <summary>
    /// 计划结束时间
    /// </summary>
    public DateTime? PlanEndTime { get; set; }

    /// <summary>
    /// 实际开始时间
    /// </summary>
    public DateTime? BeginTime { get; set; }

    /// <summary>
    /// 实际结束时间
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 状态（创建、盘点中、盘点暂停、盘点完成、盘点结果已上报、已确认盘点结果）
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 0表示暗盘，1表示明盘，默认暗盘（盘点时不显示系统数量）
    /// </summary>
    public string? IsLight { get; set; }

    /// <summary>
    /// 盘点类型是部分盘点，需设置盘点比例
    /// </summary>
    public decimal? StockingPercent { get; set; }

    /// <summary>
    /// 是否冻结出入库(1表示冻结出入库，0表示可以出入库)，全盘是冻结出入库
    /// </summary>
    public string? IsStatic { get; set; }
}
