using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 穿梭车表
/// </summary>
public partial class RobotCarInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string RobotCarId { get; set; } = null!;

    /// <summary>
    /// 小车号
    /// </summary>
    public string? RobotCarIno { get; set; }

    /// <summary>
    /// 所在当前巷道
    /// </summary>
    public string? CurrentRoadway { get; set; }

    /// <summary>
    /// 所在当前层
    /// </summary>
    public int? CurrentLayer { get; set; }

    /// <summary>
    /// 小车状态：1正常；2不可用(人工禁用)；15故障
    /// </summary>
    public short? State { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 修改人
    /// </summary>
    public string? Updator { get; set; }

    /// <summary>
    /// 修改时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 当前行走位置（第多少个货位）
    /// </summary>
    public int? CurrentTravel { get; set; }

    /// <summary>
    /// 当前车内货位状态：1有货；2无货
    /// </summary>
    public short? CurrentStorage { get; set; }
}
