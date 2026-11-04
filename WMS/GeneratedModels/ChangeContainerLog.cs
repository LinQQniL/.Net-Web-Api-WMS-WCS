using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 来料原箱翻包日志
/// </summary>
public partial class ChangeContainerLog
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string ChangeContainerLogId { get; set; } = null!;

    /// <summary>
    /// 翻包台编号
    /// </summary>
    public string StationNo { get; set; } = null!;

    /// <summary>
    /// 原箱物料标签二维码
    /// </summary>
    public string OldMaterialQrcode { get; set; } = null!;

    /// <summary>
    /// 原箱号
    /// </summary>
    public string? OldContainerNo { get; set; }

    /// <summary>
    /// 原箱长
    /// </summary>
    public string? OldContainerLong { get; set; }

    /// <summary>
    /// 原箱宽
    /// </summary>
    public string? OldContainerWidth { get; set; }

    /// <summary>
    /// 原箱高
    /// </summary>
    public string? OldContainerHigh { get; set; }

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
    /// 来料装载数量
    /// </summary>
    public decimal? OldNumber { get; set; }

    /// <summary>
    /// 装配工位
    /// </summary>
    public string? UrnPackStation { get; set; }

    /// <summary>
    /// 单号
    /// </summary>
    public string? BillNo { get; set; }

    /// <summary>
    /// 单行号
    /// </summary>
    public string? BillItemNo { get; set; }

    /// <summary>
    /// EU箱号
    /// </summary>
    public string? NewContainerNo { get; set; }

    /// <summary>
    /// EU箱装载数量
    /// </summary>
    public decimal? NewNumber { get; set; }

    /// <summary>
    /// 翻包时间
    /// </summary>
    public DateTime? ChangeContainerDate { get; set; }

    /// <summary>
    /// 操作人
    /// </summary>
    public string Operator { get; set; } = null!;

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 开始翻包时间
    /// </summary>
    public DateTime? BeginTime { get; set; }

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string? Werks { get; set; }

    /// <summary>
    /// 仓库号
    /// </summary>
    public string? WhNumber { get; set; }
}
