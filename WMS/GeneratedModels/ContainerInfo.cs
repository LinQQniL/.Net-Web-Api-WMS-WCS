using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 容器表
/// </summary>
public partial class ContainerInfo
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string ContainerId { get; set; } = null!;

    /// <summary>
    /// 容器号
    /// </summary>
    public string ContainerCode { get; set; } = null!;

    /// <summary>
    /// 容器类型
    /// </summary>
    public string ContainerType { get; set; } = null!;

    /// <summary>
    /// 创建人
    /// </summary>
    public string? Creator { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
