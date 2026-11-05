using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 退料入库推送单
/// </summary>
public partial class PushReturnMaterial
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string PushReturnMaterialId { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 退料编号
    /// </summary>
    public string ReturnNo { get; set; } = null!;

    /// <summary>
    /// 退料行编号
    /// </summary>
    public string ReturnItemNo { get; set; } = null!;

    /// <summary>
    /// 物料编码
    /// </summary>
    public string Matnr { get; set; } = null!;

    /// <summary>
    /// 物料描述
    /// </summary>
    public string? Maktx { get; set; }

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? Lifnr { get; set; }

    /// <summary>
    /// 库存地点
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 退货人
    /// </summary>
    public string? ReturnPeople { get; set; }

    /// <summary>
    /// 退货原因
    /// </summary>
    public string? ReturnReasonDesc { get; set; }

    /// <summary>
    /// 收货号
    /// </summary>
    public string? ReceiptNo { get; set; }

    /// <summary>
    /// 收货行号
    /// </summary>
    public string? ReceiptItemNo { get; set; }

    /// <summary>
    /// 需求号
    /// </summary>
    public string? RequriementNo { get; set; }

    /// <summary>
    /// 需求行号
    /// </summary>
    public string? RequriementItemNo { get; set; }

    /// <summary>
    /// 责任方
    /// </summary>
    public string? ResponsibleParty { get; set; }

    /// <summary>
    /// 审批意见
    /// </summary>
    public string? ApprovalComments { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? EditDate { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? Sobkz { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// 业务名称
    /// </summary>
    public string? BusinessName { get; set; }

    /// <summary>
    /// STO退货单号
    /// </summary>
    public string? SapOutNo { get; set; }

    /// <summary>
    /// STO退货单行号
    /// </summary>
    public string? SapOutItemNo { get; set; }

    /// <summary>
    /// 完成退货入库数量
    /// </summary>
    public decimal? CompleteNumber { get; set; }

    /// <summary>
    /// 退货入库是否完成
    /// </summary>
    public string? IsComplete { get; set; }

    /// <summary>
    /// 是否推送退料入库结果
    /// </summary>
    public string? IsPushResult { get; set; }

    /// <summary>
    /// 立库标识
    /// </summary>
    public string? Sysnod { get; set; }

    /// <summary>
    /// 已推送给WMS数量
    /// </summary>
    public decimal? PostCount { get; set; }

    /// <summary>
    /// 导入数据是否已处理
    /// </summary>
    public bool? IsDeal { get; set; }
}
