using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 入库分配表
/// </summary>
public partial class StoreInLog
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StoreInLogId { get; set; } = null!;

    /// <summary>
    /// 库存地点（WMS）
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? StockType { get; set; }

    /// <summary>
    /// 箱号
    /// </summary>
    public string? ContainerCode { get; set; }

    /// <summary>
    /// 工作站台编号
    /// </summary>
    public string? StationCode { get; set; }

    /// <summary>
    /// 入库数量
    /// </summary>
    public decimal? InStoreQty { get; set; }

    /// <summary>
    /// 入库类别（收货入库、移储入库、退料入库）
    /// </summary>
    public string? StockInType { get; set; }

    /// <summary>
    /// 单号
    /// </summary>
    public string? BillNo { get; set; }

    /// <summary>
    /// 行号
    /// </summary>
    public string? BillItemNo { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 完成时间
    /// </summary>
    public DateTime? CompleteDate { get; set; }

    /// <summary>
    /// 单据状态（创建、完成、取消）
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 入库完成后是否推送BYD WMS(0表示未推送，1表示已推送，2表示无需推送)
    /// </summary>
    public short? IsPushResult { get; set; }

    /// <summary>
    /// 料箱货位类型（64表示600*400，86表示800*600,43表示400*300）或托盘货位类型
    /// </summary>
    public string? LocationType { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 是否零头托/箱(1代表零头箱，默认是0代表整箱)
    /// </summary>
    public short? IsZeroBox { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// BYD仓库号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 库存外键
    /// </summary>
    public string? StockInfoId { get; set; }

    /// <summary>
    /// 是否外侧空闲
    /// </summary>
    public short? IsOuterIdle { get; set; }

    public string? KeyId { get; set; }
}
