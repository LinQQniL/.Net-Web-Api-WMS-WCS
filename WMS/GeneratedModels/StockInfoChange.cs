using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库存变动记录
/// </summary>
public partial class StockInfoChange
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StockInfoChangeId { get; set; } = null!;

    /// <summary>
    /// 库存ID
    /// </summary>
    public string? StockInfoId { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string WarehouseCode { get; set; } = null!;

    /// <summary>
    /// 库区编号
    /// </summary>
    public string AreaCode { get; set; } = null!;

    /// <summary>
    /// 箱号/托盘号
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// 供应商编号
    /// </summary>
    public string? SupplierCode { get; set; }

    /// <summary>
    /// 物料编码
    /// </summary>
    public string? MaterialCode { get; set; }

    /// <summary>
    /// 批次号
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// 库存地点（WMS）
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? StockType { get; set; }

    /// <summary>
    /// 单据类别（收货入库、移储入库、退料入库、非生产物料入库、拆零入库、总装出库）
    /// </summary>
    public string BillType { get; set; } = null!;

    /// <summary>
    /// 单号
    /// </summary>
    public string? BillNo { get; set; }

    /// <summary>
    /// 行号
    /// </summary>
    public string? BillItemNo { get; set; }

    /// <summary>
    /// 改变前库存数量
    /// </summary>
    public decimal? ItemQty { get; set; }

    /// <summary>
    /// 改变后库存数量
    /// </summary>
    public decimal? ChangeQty { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
