using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 出库分拣分配表
/// </summary>
public partial class OutStoreDetailAllocateInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 上传时间
    /// </summary>
    public DateTime? PostBackTime { get; set; }

    /// <summary>
    /// 箱号ID/托盘号
    /// </summary>
    public string? ContainerId { get; set; }

    /// <summary>
    /// 状态（创建、已完成、部分完成）
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 拆分条码
    /// </summary>
    public string? SplitBarcodeNo { get; set; }

    /// <summary>
    /// 出库工位ID
    /// </summary>
    public string? StationId { get; set; }

    /// <summary>
    /// 出库需求明细表ID
    /// </summary>
    public string OutBoundDetailInfoId { get; set; } = null!;

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 物料ID
    /// </summary>
    public string? MaterialId { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public DateTime? FinishTime { get; set; }

    /// <summary>
    /// 条码编号
    /// </summary>
    public string? BarcodeNo { get; set; }

    /// <summary>
    /// 分拣人
    /// </summary>
    public string? PickBy { get; set; }

    /// <summary>
    /// 分拣时间
    /// </summary>
    public DateTime? PickInTime { get; set; }

    /// <summary>
    /// 物料编码
    /// </summary>
    public string? MaterialCode { get; set; }

    /// <summary>
    /// 物料批次
    /// </summary>
    public string LotNo { get; set; } = null!;

    /// <summary>
    /// 实际拣配数量
    /// </summary>
    public decimal? FactQuantity { get; set; }

    /// <summary>
    /// 预约锁定拣配数量
    /// </summary>
    public decimal? LockQuantity { get; set; }

    /// <summary>
    /// 箱号/托盘号
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string SupplierCode { get; set; } = null!;

    /// <summary>
    /// 拣配口编号
    /// </summary>
    public string StationCode { get; set; } = null!;

    /// <summary>
    /// 终点设备编号(拣配口)
    /// </summary>
    public string? EndEquipmentCode { get; set; }

    /// <summary>
    /// 出库需求号
    /// </summary>
    public string? RequirementNo { get; set; }

    /// <summary>
    /// 出库需求行号
    /// </summary>
    public string? RequirementItemNo { get; set; }

    /// <summary>
    /// 是否推送出库完成结果(待推送0，1次推送后改成1，无需推送或推送完成2)
    /// </summary>
    public string? IsPushResult { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 区域编码
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 托盘库小件翻包工位设备编号
    /// </summary>
    public string? EquipmentCode { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// BYD仓库号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 分配类别(总装出库/移储出库/普通出库/退库出库/小件翻包出库/盘点/抽检/拆箱)
    /// </summary>
    public string? AllocateType { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    public int? Priority { get; set; }

    public string? StockType { get; set; }

    public string? Lgort { get; set; }

    public string? KeyId { get; set; }
}
