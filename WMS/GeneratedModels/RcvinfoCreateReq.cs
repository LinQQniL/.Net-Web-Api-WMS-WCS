using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 接收移储单信息
/// </summary>
public partial class RcvinfoCreateReq
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string RcvinfoCreateReqId { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 立库标识
    /// </summary>
    public string Sysnod { get; set; } = null!;

    /// <summary>
    /// 全局ID(IWMS系统号+流水号)
    /// </summary>
    public string KeyId { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string Lifnr { get; set; } = null!;

    /// <summary>
    /// 物料号
    /// </summary>
    public string Matnr { get; set; } = null!;

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 满箱数量(若未传值，默认与“数量”相等)
    /// </summary>
    public decimal? BoxQty { get; set; }

    /// <summary>
    /// 源储位
    /// </summary>
    public string? BinCode { get; set; }

    /// <summary>
    /// 接收储位
    /// </summary>
    public string? ReceivingBinCode { get; set; }

    /// <summary>
    /// 库位
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 完成移储入库数量
    /// </summary>
    public decimal? CompleteNumber { get; set; }

    /// <summary>
    /// 移储入库是否完成
    /// </summary>
    public string? IsComplete { get; set; }

    /// <summary>
    /// 移储单号
    /// </summary>
    public string? RcvinfoCreateReqCode { get; set; }
}
