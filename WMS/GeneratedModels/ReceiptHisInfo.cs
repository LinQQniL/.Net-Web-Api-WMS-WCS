using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ReceiptHisInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string ReceiptId { get; set; } = null!;

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
    /// 供应商代码
    /// </summary>
    public string Lifnr { get; set; } = null!;

    /// <summary>
    /// 供应商描述
    /// </summary>
    public string Liktx { get; set; } = null!;

    /// <summary>
    /// 收货单号
    /// </summary>
    public string ReceiptNo { get; set; } = null!;

    /// <summary>
    /// 收货单行号
    /// </summary>
    public string ReceiptItemNo { get; set; } = null!;

    /// <summary>
    /// 实收数量
    /// </summary>
    public decimal? ReceiptQty { get; set; }

    /// <summary>
    /// 业务类型
    /// </summary>
    public string? BusinessName { get; set; }

    /// <summary>
    /// wms 业务类型
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// 删除标识
    /// </summary>
    public string? Del { get; set; }

    /// <summary>
    /// 发货工厂代码
    /// </summary>
    public string? FWerks { get; set; }

    /// <summary>
    /// 发货仓库号
    /// </summary>
    public string? FWhNumber { get; set; }

    /// <summary>
    /// 发货库位
    /// </summary>
    public string? FLgort { get; set; }

    /// <summary>
    /// 发货批次
    /// </summary>
    public string? FBatch { get; set; }

    /// <summary>
    /// 收货库位
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// WMS 批次
    /// </summary>
    public string? Batch { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? Sobkz { get; set; }

    /// <summary>
    /// 物料号
    /// </summary>
    public string? Matnr { get; set; }

    /// <summary>
    /// 物料描述
    /// </summary>
    public string? Maktx { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 满箱数量
    /// </summary>
    public decimal? FullBoxQty { get; set; }

    /// <summary>
    /// 箱数
    /// </summary>
    public decimal? BoxCount { get; set; }

    /// <summary>
    /// 质检标识(00质检、01免检、02无需质检的收料房库存可进仓也可退货)
    /// </summary>
    public string? TestFlag { get; set; }

    /// <summary>
    /// SCM/云平台送货单号
    /// </summary>
    public string? Asnno { get; set; }

    /// <summary>
    /// SCM 送货单行项目号
    /// </summary>
    public string? Asnitm { get; set; }

    /// <summary>
    /// 采购订单号
    /// </summary>
    public string? PoNo { get; set; }

    /// <summary>
    /// 采购订单行项目号
    /// </summary>
    public string? PoItemNo { get; set; }

    /// <summary>
    /// SAP 交货单号
    /// </summary>
    public string? SapOutNo { get; set; }

    /// <summary>
    /// SAP 交货单行项目号
    /// </summary>
    public string? SapOutItemNo { get; set; }

    /// <summary>
    /// SAP303 凭证号
    /// </summary>
    public string? SapMatdocNo { get; set; }

    /// <summary>
    /// SAP303 凭证行项目号
    /// </summary>
    public string? SapMatdocItemNo { get; set; }

    /// <summary>
    /// 申请人
    /// </summary>
    public string? Afnam { get; set; }

    /// <summary>
    /// 需求跟踪号
    /// </summary>
    public string? Bednr { get; set; }

    /// <summary>
    /// 收料日期
    /// </summary>
    public DateTime ReceiptDate { get; set; }

    /// <summary>
    /// 收料员
    /// </summary>
    public string? Receiver { get; set; }

    /// <summary>
    /// 收料房存放区
    /// </summary>
    public string? GrArea { get; set; }

    /// <summary>
    /// 收料房冲销/退货数理 104+124 数量
    /// </summary>
    public decimal? ReturnQty { get; set; }

    /// <summary>
    /// 可进仓数量（质检判断结果为可进仓）
    /// </summary>
    public decimal? InableQty { get; set; }

    /// <summary>
    /// 进仓数量
    /// </summary>
    public decimal? InQty { get; set; }

    /// <summary>
    /// 记录创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// WBS 元素号
    /// </summary>
    public string? Wbs { get; set; }

    /// <summary>
    /// 项目编号
    /// </summary>
    public string? ProjectOreder { get; set; }

    /// <summary>
    /// 是否 SAP 过
    /// 账用于先
    /// 实物
    /// </summary>
    public string? SapStatus { get; set; }

    /// <summary>
    /// SAP 交货数量
    /// </summary>
    public decimal? SapQty { get; set; }

    /// <summary>
    /// 零件编号
    /// </summary>
    public string? PartNo { get; set; }

    /// <summary>
    /// 收货储位
    /// </summary>
    public string? StoreBinCode { get; set; }

    /// <summary>
    /// 抽检数量
    /// </summary>
    public decimal? CheckedQty { get; set; }

    /// <summary>
    /// 质检结果
    /// </summary>
    public string? QcResultCode { get; set; }

    /// <summary>
    /// 进仓单号
    /// </summary>
    public string? InboundNo { get; set; }

    /// <summary>
    /// 进仓单行号
    /// </summary>
    public string? InboundItemNo { get; set; }

    /// <summary>
    /// WMS 凭证
    /// </summary>
    public string? WmsNo { get; set; }

    /// <summary>
    /// SAP 凭证
    /// </summary>
    public string? SapNo { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string? InbounStatus { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// 请求类型
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 是否有效
    /// </summary>
    public string? IsValid { get; set; }

    /// <summary>
    /// 是否全部完成
    /// </summary>
    public short? IsComplete { get; set; }

    /// <summary>
    /// 导入数据是否已处理
    /// </summary>
    public bool? IsDeal { get; set; }
}
