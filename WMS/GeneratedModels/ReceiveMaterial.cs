using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 接收到的物料主数据表
/// </summary>
public partial class ReceiveMaterial
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string ReceiveMaterialId { get; set; } = null!;

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string Lifnr { get; set; } = null!;

    /// <summary>
    /// 供应商描述
    /// </summary>
    public string Liktx { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 物料号
    /// </summary>
    public string Matnr { get; set; } = null!;

    /// <summary>
    /// 物料描述
    /// </summary>
    public string Maktx { get; set; } = null!;

    /// <summary>
    /// 有效状态x（有效）0 （无效）
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 工位
    /// </summary>
    public string? Station { get; set; }

    /// <summary>
    /// 线体（工段）
    /// </summary>
    public string? DispatchingSection { get; set; }

    /// <summary>
    /// 上线方式
    /// </summary>
    public string? DispatchingType { get; set; }

    /// <summary>
    /// 站点
    /// </summary>
    public string? Site { get; set; }

    /// <summary>
    /// 包装代码
    /// </summary>
    public string? PackCode { get; set; }

    /// <summary>
    /// 是否翻包
    /// </summary>
    public string? TurnPack { get; set; }

    /// <summary>
    /// 来料标准装载量
    /// </summary>
    public decimal? IncomStanLoadQty { get; set; }

    /// <summary>
    /// 来料标装运载量
    /// </summary>
    public decimal? IncomStanTranQty { get; set; }

    /// <summary>
    /// 上线标装装载量
    /// </summary>
    public decimal? OnlineStanLoadQty { get; set; }

    /// <summary>
    /// 上线标准运载量
    /// </summary>
    public decimal? OnlineStanTranQty { get; set; }

    /// <summary>
    /// 翻包模式
    /// </summary>
    public string? TurnPackType { get; set; }

    /// <summary>
    /// 集中翻包区
    /// </summary>
    public string? TurnPackRegion { get; set; }

    /// <summary>
    /// 集中翻包工位
    /// </summary>
    public string? TurnPackStation { get; set; }

    /// <summary>
    /// 是否上立库标识
    /// </summary>
    public string? LikuFlag { get; set; }

    /// <summary>
    /// 单车用量
    /// </summary>
    public string? PerAuto { get; set; }

    /// <summary>
    /// 车型信息
    /// </summary>
    public string? CarTypy { get; set; }

    /// <summary>
    /// 标准码托箱数
    /// </summary>
    public decimal? StandardBoxQty { get; set; }

    /// <summary>
    /// 物料单位
    /// </summary>
    public string? Meins { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// 出立库编码
    /// </summary>
    public string? SendnoOut { get; set; }

    /// <summary>
    /// 物料库存上限
    /// </summary>
    public decimal? MaterialInventoryLimit { get; set; }

    /// <summary>
    /// 物料库存下限
    /// </summary>
    public decimal? MaterialInventoryMinimum { get; set; }

    /// <summary>
    /// 是否套箱
    /// </summary>
    public string? UseBoxing { get; set; }

    /// <summary>
    /// 来料包装代码
    /// </summary>
    public string? IncomPackCode { get; set; }

    /// <summary>
    /// 入立库编码
    /// </summary>
    public string? Sysnod { get; set; }

    /// <summary>
    /// 零件重量
    /// </summary>
    public string? PartWeight { get; set; }

    /// <summary>
    /// 导入数据是否已处理
    /// </summary>
    public bool? IsDeal { get; set; }
}
