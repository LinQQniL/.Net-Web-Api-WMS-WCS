using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 事件日志
/// </summary>
public partial class EventLogInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string EventLogId { get; set; } = null!;

    /// <summary>
    /// 料箱码/托盘号
    /// </summary>
    public string? ContainerBarcode { get; set; }

    /// <summary>
    /// 设备编码
    /// </summary>
    public string? EquipmentCode { get; set; }

    /// <summary>
    /// 日志内容
    /// </summary>
    public string? EventLog { get; set; }

    /// <summary>
    /// 级别
    /// </summary>
    public int? EventLevel { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    public string? EventLogEn { get; set; }

    public string? EventLogThird { get; set; }
}
