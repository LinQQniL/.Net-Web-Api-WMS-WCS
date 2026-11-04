using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 故障代码表
/// </summary>
public partial class FaultCodeInfo
{
    /// <summary>
    /// 故障代码表ID
    /// </summary>
    public string FaultCodeId { get; set; } = null!;

    /// <summary>
    /// 故障代码
    /// </summary>
    public string FaultCode { get; set; } = null!;

    /// <summary>
    /// 故障名称
    /// </summary>
    public string FaultName { get; set; } = null!;

    /// <summary>
    /// 设备类型(0、平面设备1、堆垛机设备2、机械手)
    /// </summary>
    public string? EquipmentType { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public bool? IsEnable { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

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
}
