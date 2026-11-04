using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库位表
/// </summary>
public partial class LocationInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string LocationId { get; set; } = null!;

    /// <summary>
    /// 仓库
    /// </summary>
    public string WarehouseId { get; set; } = null!;

    /// <summary>
    /// 区域
    /// </summary>
    public string AreaId { get; set; } = null!;

    /// <summary>
    /// 巷道编号
    /// </summary>
    public string EquipmentCode { get; set; } = null!;

    /// <summary>
    /// 货位编号
    /// </summary>
    public string LocationNumber { get; set; } = null!;

    /// <summary>
    /// 行
    /// </summary>
    public int LocationLine { get; set; }

    /// <summary>
    /// 列
    /// </summary>
    public int LocationColumn { get; set; }

    /// <summary>
    /// 层
    /// </summary>
    public int LocationLayer { get; set; }

    /// <summary>
    /// 深度
    /// </summary>
    public int LocationDepth { get; set; }

    /// <summary>
    /// 货位用途
    /// </summary>
    public string? LocationUse { get; set; }

    /// <summary>
    /// 货位类型
    /// </summary>
    public string LocationType { get; set; } = null!;

    /// <summary>
    /// 货位状态
    /// </summary>
    public string LocationState { get; set; } = null!;

    /// <summary>
    /// 料箱号
    /// </summary>
    public string? ContainerBarcode { get; set; }

    /// <summary>
    /// 入库时间
    /// </summary>
    public DateTime? InboundTime { get; set; }

    /// <summary>
    /// 出库时间
    /// </summary>
    public DateTime? OutboundTime { get; set; }

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
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 检测柜状态
    /// </summary>
    public int? StatusCode { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public bool IsEnable { get; set; }

    /// <summary>
    /// 检测柜状态
    /// </summary>
    public bool? FireState { get; set; }
}
