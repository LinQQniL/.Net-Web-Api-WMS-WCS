using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 空EU箱呼叫记录
/// </summary>
public partial class EucallLog
{
    /// <summary>
    /// 唯一编码
    /// </summary>
    public string EucallLogId { get; set; } = null!;

    /// <summary>
    /// EU箱类型
    /// </summary>
    public string ContainerType { get; set; } = null!;

    /// <summary>
    /// 呼叫数量
    /// </summary>
    public int? CallNum { get; set; }

    /// <summary>
    /// 已完成数量
    /// </summary>
    public int? CompleteNum { get; set; }

    /// <summary>
    /// 是否已完成 0未完成 1已完成
    /// </summary>
    public short? IsComplete { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 呼叫时间
    /// </summary>
    public DateTime? CallTime { get; set; }

    /// <summary>
    /// 呼叫站点
    /// </summary>
    public string? CallStation { get; set; }

    /// <summary>
    /// 目标设备
    /// </summary>
    public string? TargetEquipmentCode { get; set; }

    /// <summary>
    /// 呼叫托盘号
    /// </summary>
    public string? TrayContainerCode { get; set; }

    /// <summary>
    /// 呼叫的EU箱号(多个)
    /// </summary>
    public string? EuContainerCodes { get; set; }
}
