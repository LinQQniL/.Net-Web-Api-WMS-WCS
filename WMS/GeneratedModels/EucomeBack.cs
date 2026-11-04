using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 回库空EU箱列表
/// </summary>
public partial class EucomeBack
{
    /// <summary>
    /// 唯一编码
    /// </summary>
    public string EucomeBackId { get; set; } = null!;

    /// <summary>
    /// 空箱条码
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// EU箱类型
    /// </summary>
    public string ContainerType { get; set; } = null!;

    /// <summary>
    /// 目标设备
    /// </summary>
    public string? TargetEquipmentCode { get; set; }

    /// <summary>
    /// 是否已匹配呼叫 0未匹配 1已匹配
    /// </summary>
    public short? CallFlag { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 扫码时间
    /// </summary>
    public DateTime? ArriveTime { get; set; }
}
