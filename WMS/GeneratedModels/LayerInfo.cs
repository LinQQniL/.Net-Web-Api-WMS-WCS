using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 料箱库层状态表
/// </summary>
public partial class LayerInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string LayerInfoId { get; set; } = null!;

    /// <summary>
    /// 巷道号
    /// </summary>
    public string StackerCode { get; set; } = null!;

    /// <summary>
    /// 层号
    /// </summary>
    public int LayerCode { get; set; }

    /// <summary>
    /// 是否有车
    /// </summary>
    public bool? HasCar { get; set; }

    /// <summary>
    /// 是否兼容多尺寸料箱
    /// </summary>
    public bool? IsCompatible { get; set; }

    /// <summary>
    /// 专用料箱类型比如：EU8628,86代表800*600,28代表高度280
    /// </summary>
    public string? SpecialEu { get; set; }

    /// <summary>
    /// 层状态：1正常；2不可用(人工禁用)；
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
    /// 层高
    /// </summary>
    public int? Height { get; set; }
}
