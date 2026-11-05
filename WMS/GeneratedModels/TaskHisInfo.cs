using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 任务历史主表
/// </summary>
public partial class TaskHisInfo
{
    /// <summary>
    /// 任务历史信息ID
    /// </summary>
    public string TaskHisId { get; set; } = null!;

    /// <summary>
    /// 添加时间
    /// </summary>
    public DateTime InsertTime { get; set; }

    /// <summary>
    /// 任务ID
    /// </summary>
    public string TaskId { get; set; } = null!;

    /// <summary>
    /// 任务号
    /// </summary>
    public int TaskNumber { get; set; }

    /// <summary>
    /// 任务类型
    /// </summary>
    public string TaskType { get; set; } = null!;

    /// <summary>
    /// 任务状态
    /// </summary>
    public string TaskState { get; set; } = null!;

    /// <summary>
    /// 路径ID
    /// </summary>
    public string RouteId { get; set; } = null!;

    /// <summary>
    /// 起始设备
    /// </summary>
    public string SourceEquipment { get; set; } = null!;

    /// <summary>
    /// 当前设备
    /// </summary>
    public string CurrentEquipment { get; set; } = null!;

    /// <summary>
    /// 目标设备
    /// </summary>
    public string TargetEquipment { get; set; } = null!;

    /// <summary>
    /// 起始货位
    /// </summary>
    public string FromAddress { get; set; } = null!;

    /// <summary>
    /// 目标货位
    /// </summary>
    public string ToAddress { get; set; } = null!;

    /// <summary>
    /// 优先级
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// 优先级改变时间
    /// </summary>
    public DateTime? PriorityChangeTime { get; set; }

    /// <summary>
    /// 依赖任务号
    /// </summary>
    public string? DependTask { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// 业务标识ID
    /// </summary>
    public string? BusinessId { get; set; }

    /// <summary>
    /// 业务明细ID
    /// </summary>
    public string? BusinessDetailId { get; set; }

    /// <summary>
    /// 托盘编码
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    public string? Remark { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 开始时间
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public DateTime? FinishTime { get; set; }

    /// <summary>
    /// 取消时间
    /// </summary>
    public DateTime? CancelTime { get; set; }

    /// <summary>
    /// 终点设备
    /// </summary>
    public string? EndtEquipment { get; set; }
}
