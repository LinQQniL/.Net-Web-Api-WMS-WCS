using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 静置信息表
/// </summary>
public partial class StandingInfo
{
    /// <summary>
    /// 静置信息表ID
    /// </summary>
    public string StandingId { get; set; } = null!;

    /// <summary>
    /// 托盘ID
    /// </summary>
    public string InventoryId { get; set; } = null!;

    /// <summary>
    /// 托盘编码
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// 货位编码
    /// </summary>
    public string LocationNumber { get; set; } = null!;

    /// <summary>
    /// 流程实例节点ID
    /// </summary>
    public string ProcessCaseNodeId { get; set; } = null!;

    /// <summary>
    /// 流程节点名称
    /// </summary>
    public string ProcessNodeName { get; set; } = null!;

    /// <summary>
    /// 开始时间
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 预计结束时间
    /// </summary>
    public DateTime ExpectEndTime { get; set; }

    /// <summary>
    /// 实际结束时间
    /// </summary>
    public DateTime? ActualEndTime { get; set; }

    /// <summary>
    /// 静置时长
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// 最大静置时长
    /// </summary>
    public int DurationMax { get; set; }

    /// <summary>
    /// 是否结束
    /// </summary>
    public bool IsEnd { get; set; }

    /// <summary>
    /// 是否出库
    /// </summary>
    public bool IsOut { get; set; }

    /// <summary>
    /// 入库开始时间
    /// </summary>
    public DateTime? InboundStartTime { get; set; }

    /// <summary>
    /// 入库完成时间
    /// </summary>
    public DateTime? InboundFinishTime { get; set; }

    /// <summary>
    /// 出库开始时间
    /// </summary>
    public DateTime? OutboundStartTime { get; set; }

    /// <summary>
    /// 出库完成时间
    /// </summary>
    public DateTime? OutboundFinishTime { get; set; }
}
