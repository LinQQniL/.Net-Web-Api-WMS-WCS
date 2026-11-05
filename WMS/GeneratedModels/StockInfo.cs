using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库存表
/// </summary>
public partial class StockInfo
{
    /// <summary>
    /// 库存ID
    /// </summary>
    public string StockInfoId { get; set; } = null!;

    /// <summary>
    /// 托盘号
    /// </summary>
    public string? ContainerCode { get; set; }

    /// <summary>
    /// 物料ID
    /// </summary>
    public string? MaterialId { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? ItemQty { get; set; }

    /// <summary>
    /// 已分配数量
    /// </summary>
    public decimal? AllocatedQty { get; set; }

    /// <summary>
    /// 库存状态（ 0正常、1在途、2质检不合格、3盘点中、4盘亏、5盘盈）
    /// </summary>
    public int? InventoryState { get; set; }

    /// <summary>
    /// 标签条码
    /// </summary>
    public string? LabelBarcode { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 预留字段1
    /// </summary>
    public string? Field1 { get; set; }

    /// <summary>
    /// 预留字段2
    /// </summary>
    public string? Field2 { get; set; }

    /// <summary>
    /// 预留字段3
    /// </summary>
    public string? Field3 { get; set; }

    /// <summary>
    /// 预留字段4
    /// </summary>
    public string? Field4 { get; set; }

    /// <summary>
    /// 预留字段5
    /// </summary>
    public string? Field5 { get; set; }

    /// <summary>
    /// 预留字段6
    /// </summary>
    public string? Field6 { get; set; }

    /// <summary>
    /// 预留字段7
    /// </summary>
    public string? Field7 { get; set; }

    /// <summary>
    /// 预留字段8
    /// </summary>
    public string? Field8 { get; set; }

    /// <summary>
    /// 预留字段9
    /// </summary>
    public string? Field9 { get; set; }

    /// <summary>
    /// 预留字段10
    /// </summary>
    public string? Field10 { get; set; }

    /// <summary>
    /// 重量
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// 锁定数量
    /// </summary>
    public decimal? LockQty { get; set; }

    /// <summary>
    /// 批次
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// 生产日期
    /// </summary>
    public DateTime? ProductionDate { get; set; }

    /// <summary>
    /// 过期时间
    /// </summary>
    public DateTime? ExpireDate { get; set; }

    /// <summary>
    /// 冻结备注
    /// </summary>
    public string? LockRemark { get; set; }

    /// <summary>
    /// 冻结人
    /// </summary>
    public string? LockUser { get; set; }

    /// <summary>
    /// 序列号,唯一标识符,用于确定商品的唯一性
    /// </summary>
    public string? SequenceNo { get; set; }

    /// <summary>
    /// 供应商编号
    /// </summary>
    public string? SupplierCode { get; set; }

    /// <summary>
    /// 物料编码
    /// </summary>
    public string? MaterialCode { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 冻结状态（0解冻、1冻结）
    /// </summary>
    public short? FreezeStatus { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// 盘点状态(0正常、3盘点预约中、4盘亏、5盘盈)
    /// </summary>
    public int? StockingStatus { get; set; }

    /// <summary>
    /// 质检状态(0正常，6待质检，7质检不合格)
    /// </summary>
    public int? QualityStatus { get; set; }
}
