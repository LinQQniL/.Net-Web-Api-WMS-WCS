using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 出库单明细表
/// </summary>
public partial class OutBoundDetailInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string OutBoundDetailInfoId { get; set; } = null!;

    /// <summary>
    /// 发货单号
    /// </summary>
    public string BillNo { get; set; } = null!;

    /// <summary>
    /// 发货单行号
    /// </summary>
    public string BillLineNo { get; set; } = null!;

    /// <summary>
    /// 物料ID
    /// </summary>
    public string MaterialId { get; set; } = null!;

    /// <summary>
    /// 物料编码
    /// </summary>
    public string MaterialCode { get; set; } = null!;

    /// <summary>
    /// 物料名称
    /// </summary>
    public string MaterialName { get; set; } = null!;

    /// <summary>
    /// 批次号
    /// </summary>
    public string? LotNo { get; set; }

    /// <summary>
    /// 基本计量单位
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// 发货单数量
    /// </summary>
    public decimal? BillQty { get; set; }

    /// <summary>
    /// 实发数量
    /// </summary>
    public decimal? ActualQty { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string Creator { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 出库主单Id
    /// </summary>
    public string OutBoundHeaderInfoId { get; set; } = null!;

    /// <summary>
    /// 0：已创建 、1：已部分分配、2、已全部分配、3：已部分回传、4：已全部回传、5、已关闭
    /// </summary>
    public int DetailStatus { get; set; }

    /// <summary>
    /// 已上报数量
    /// </summary>
    public int? PostCount { get; set; }

    /// <summary>
    /// 单据类型
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
    /// 更新人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

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
    /// 优先级
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// 库存类型
    /// </summary>
    public string? StockType { get; set; }
}
