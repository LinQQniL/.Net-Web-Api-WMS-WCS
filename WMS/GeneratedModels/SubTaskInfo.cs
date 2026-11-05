using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 任务子表
/// </summary>
public partial class SubTaskInfo
{
    /// <summary>
    /// 任务明细表ID
    /// </summary>
    public string SubTaskId { get; set; } = null!;

    /// <summary>
    /// 任务ID
    /// </summary>
    public string TaskId { get; set; } = null!;

    /// <summary>
    /// 任务号
    /// </summary>
    public int TaskNumber { get; set; }

    /// <summary>
    /// 路径ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 业务明细ID
    /// </summary>
    public string DetailId { get; set; } = null!;

    public string? RouteType { get; set; }

    /// <summary>
    /// 起始设备
    /// </summary>
    public string FromEquipmentCode { get; set; } = null!;

    /// <summary>
    /// 起始货位
    /// </summary>
    public string FromAddress { get; set; } = null!;

    /// <summary>
    /// 目标设备
    /// </summary>
    public string ToEquipmentCode { get; set; } = null!;

    /// <summary>
    /// 目标货位
    /// </summary>
    public string ToAddress { get; set; } = null!;

    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 开始时间
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 下一个任务明细ID
    /// </summary>
    public string? PreviousSubTaskId { get; set; }

    /// <summary>
    /// 任务明细状态
    /// </summary>
    public string SubTaskState { get; set; } = null!;

    /// <summary>
    /// 取消时间
    /// </summary>
    public DateTime? FallbackTime { get; set; }

    /// <summary>
    /// 第三方任务号
    /// </summary>
    public string? OtherSystemTaskNo { get; set; }
}
