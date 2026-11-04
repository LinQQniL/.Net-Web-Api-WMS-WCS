using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 异常任务
/// </summary>
public partial class AbnormalTask
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string AbnormalTaskId { get; set; } = null!;

    /// <summary>
    /// 任务类型（入库异常、出库异常）
    /// </summary>
    public string TaskType { get; set; } = null!;

    /// <summary>
    /// 主任务ID
    /// </summary>
    public string TaskId { get; set; } = null!;

    /// <summary>
    /// 子任务ID
    /// </summary>
    public string SubTaskId { get; set; } = null!;

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 容器条码
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// 异常排出口
    /// </summary>
    public string? StationCode { get; set; }

    /// <summary>
    /// 异常描述
    /// </summary>
    public string? Desc { get; set; }

    /// <summary>
    /// 状态（待处理、已处理、无效）
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }
}
