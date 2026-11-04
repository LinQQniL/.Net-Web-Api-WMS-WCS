using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 托盘库PDA组盘主表
/// </summary>
public partial class BindingMain
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string BindingId { get; set; } = null!;

    /// <summary>
    /// 子托盘流水号
    /// </summary>
    public string? ChildContainerCode { get; set; }

    /// <summary>
    /// 入库类别（收货入库、移储入库、退料入库）
    /// </summary>
    public string? StockInType { get; set; }

    /// <summary>
    /// 单号（可以是收货单号，移储入库单号，退料入库单号）
    /// </summary>
    public string? BillNo { get; set; }

    /// <summary>
    /// 行号
    /// </summary>
    public string? BillItemNo { get; set; }

    /// <summary>
    /// 整托来料装载数量（组盘后不会再发生改变）
    /// </summary>
    public decimal? OldNumberTotal { get; set; }

    /// <summary>
    /// 整托当前装载数量（组盘后在线翻包后会改变）
    /// </summary>
    public decimal? NewNumberTotal { get; set; }

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? Lifnr { get; set; }

    /// <summary>
    /// 供应商描述
    /// </summary>
    public string? Liktx { get; set; }

    /// <summary>
    /// 物料号
    /// </summary>
    public string? Matnr { get; set; }

    /// <summary>
    /// 生产日期
    /// </summary>
    public DateTime? MadeDate { get; set; }

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 状态(有效、无效)
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// 母托盘号（自动绑定时填入母托盘号）
    /// </summary>
    public string? ContainerCode { get; set; }

    /// <summary>
    /// 物料类型(物料、母托垛、子托垛、空包装、围板)
    /// </summary>
    public string? MaterialType { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// BYD仓库号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 收货组盘缓存位编号
    /// </summary>
    public string? CacheLocationNo { get; set; }

    /// <summary>
    /// 是否已呼叫AGV(0未呼叫，1为已成功呼叫，2为人工模式无需呼叫AGV)
    /// </summary>
    public short? IsCallAgv { get; set; }

    /// <summary>
    /// 是否绑定子托条码(1为不绑定子托)
    /// </summary>
    public string? IsBindChildContainerCode { get; set; }
}
