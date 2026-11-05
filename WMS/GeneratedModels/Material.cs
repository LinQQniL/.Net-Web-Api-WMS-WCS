using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 物料主数据表
/// </summary>
public partial class Material
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string MaterialId { get; set; } = null!;

    /// <summary>
    /// 计量单位
    /// </summary>
    public string? BasePackingTypeCode { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public string IsDeleted { get; set; } = null!;

    /// <summary>
    /// 类型名称
    /// </summary>
    public string? MaterialTypeCode { get; set; }

    /// <summary>
    /// 物料型号
    /// </summary>
    public string? MaterialDescription { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 物料名称
    /// </summary>
    public string MaterialName { get; set; } = null!;

    /// <summary>
    /// 重量下限
    /// </summary>
    public decimal? WeightLowerLimit { get; set; }

    /// <summary>
    /// 物料规格
    /// </summary>
    public string? MaterialSpec { get; set; }

    /// <summary>
    /// 重量上限
    /// </summary>
    public decimal? WeightUpperLimit { get; set; }

    /// <summary>
    /// 区域编码
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 物料编码
    /// </summary>
    public string MaterialCode { get; set; } = null!;

    /// <summary>
    /// 物料热度(0-3)值越大，热度越高，离入库口出库口最近
    /// </summary>
    public short? MaterialHeat { get; set; }

    /// <summary>
    /// 物料优先级(值越大，出库优先级越高)
    /// </summary>
    public int? MaterialPriority { get; set; }

    /// <summary>
    /// 是否料箱库物料(0是未设置，1是料箱库，2不是料箱库物料)
    /// </summary>
    public short? IsSmallPiece { get; set; }

    /// <summary>
    /// 料箱库区安全库存上警戒位
    /// </summary>
    public decimal? MinSaftyStock { get; set; }

    /// <summary>
    /// 料箱库区安全库存下警戒位
    /// </summary>
    public decimal? MaxSaftyStock { get; set; }

    /// <summary>
    /// 是否直通
    /// </summary>
    public short? IsThrough { get; set; }
}
