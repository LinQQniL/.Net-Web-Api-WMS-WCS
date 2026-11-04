using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库位分组表
/// </summary>
public partial class LocationGroupInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string LocationGroupId { get; set; } = null!;

    /// <summary>
    /// 货位分组编号
    /// </summary>
    public string LocationGroupCode { get; set; } = null!;

    /// <summary>
    /// 货位分组名称
    /// </summary>
    public string LocationGroupName { get; set; } = null!;

    /// <summary>
    /// 巷道编号
    /// </summary>
    public string EquipmentCode { get; set; } = null!;

    /// <summary>
    /// 起始行
    /// </summary>
    public int LocationRowStart { get; set; }

    /// <summary>
    /// 起始列
    /// </summary>
    public int LocationColumnStart { get; set; }

    /// <summary>
    /// 起始层
    /// </summary>
    public int LocationLayerStart { get; set; }

    /// <summary>
    /// 终止行
    /// </summary>
    public int LocationRowEnd { get; set; }

    /// <summary>
    /// 终止列
    /// </summary>
    public int LocationColumnEnd { get; set; }

    /// <summary>
    /// 终止层
    /// </summary>
    public int LocationLayerEnd { get; set; }

    /// <summary>
    /// 优先级
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public bool IsEnable { get; set; }
}
