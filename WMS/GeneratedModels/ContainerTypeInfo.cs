using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 容器类型表
/// </summary>
public partial class ContainerTypeInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string ContainerTypeId { get; set; } = null!;

    /// <summary>
    /// 类型编码
    /// </summary>
    public string ContainerTypeCode { get; set; } = null!;

    /// <summary>
    /// 类型名称
    /// </summary>
    public string ContainerTypeName { get; set; } = null!;

    /// <summary>
    /// 容器规则
    /// </summary>
    public string ContainerCodeRule { get; set; } = null!;

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
