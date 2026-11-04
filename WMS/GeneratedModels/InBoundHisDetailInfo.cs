using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class InBoundHisDetailInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string InBoundDetailInfoId { get; set; } = null!;

    /// <summary>
    /// 单号
    /// </summary>
    public string? BillNo { get; set; }

    /// <summary>
    /// 单行号
    /// </summary>
    public string? BillLineNo { get; set; }

    /// <summary>
    /// 物料ID
    /// </summary>
    public string? MaterialId { get; set; }

    /// <summary>
    /// 物料编码
    /// </summary>
    public string? MaterialCode { get; set; }

    /// <summary>
    /// 物料名称
    /// </summary>
    public string? MaterialName { get; set; }

    /// <summary>
    /// 批次号
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// 基本计量单位
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// 原单数量
    /// </summary>
    public decimal? BillQty { get; set; }

    /// <summary>
    /// 实发数量
    /// </summary>
    public decimal? ActualQty { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 入库主单Id
    /// </summary>
    public string? InBoundHeaderInfoId { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 单据类别
    /// </summary>
    public string? BillType { get; set; }

    /// <summary>
    /// 供应商代码
    /// </summary>
    public string? SupplierCode { get; set; }

    /// <summary>
    /// 供应商名称
    /// </summary>
    public string? SupplierName { get; set; }

    /// <summary>
    /// 0：已创建 、1：已完成组盘、2：已部分回传、3：已全部回传、4：已关闭
    /// </summary>
    public short? DetailStatus { get; set; }

    /// <summary>
    /// 已上报数量
    /// </summary>
    public decimal? PostCount { get; set; }

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string? FactoryNo { get; set; }

    /// <summary>
    /// BYD仓库号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 库存地点
    /// </summary>
    public string? Lgort { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? StockType { get; set; }
}
