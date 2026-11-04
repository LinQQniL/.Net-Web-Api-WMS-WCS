using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 站台缓存线体设置表
/// </summary>
public partial class StationCacheSet
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string StationCacheSetId { get; set; } = null!;

    /// <summary>
    /// 站点编号
    /// </summary>
    public string StationCode { get; set; } = null!;

    /// <summary>
    /// 终点设备编号
    /// </summary>
    public string EquipmentCode { get; set; } = null!;

    /// <summary>
    /// 缓存位数量
    /// </summary>
    public int? CacheLocationNum { get; set; }

    /// <summary>
    /// 增加的虚拟缓存位数量(可以调整数量来提升效率)
    /// </summary>
    public int? AddCacheLocationNum { get; set; }

    /// <summary>
    /// 空闲数量
    /// </summary>
    public int? FreeLocationNum { get; set; }

    /// <summary>
    /// 是否AGV接驳台（1是，其他否）
    /// </summary>
    public short? IsAgvStation { get; set; }

    /// <summary>
    /// 空箱（托）线还是满箱（托）线（空箱是0，满箱是1，空满兼用则是2）
    /// </summary>
    public short? IsFull { get; set; }

    /// <summary>
    /// 状态（0无效，1有效）
    /// </summary>
    public short? Status { get; set; }

    public string? WarehouseCode { get; set; }

    public string? AreaCode { get; set; }
}
