using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 接口设置表
/// </summary>
public partial class InterfaceInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string InterfaceId { get; set; } = null!;

    /// <summary>
    /// 接口编码
    /// </summary>
    public string InterfaceCode { get; set; } = null!;

    /// <summary>
    /// 接口名称
    /// </summary>
    public string InterfaceName { get; set; } = null!;

    /// <summary>
    /// 接口地址
    /// </summary>
    public string InterfaceUrl { get; set; } = null!;

    /// <summary>
    /// 请求方法
    /// </summary>
    public string RequestMethod { get; set; } = null!;

    /// <summary>
    /// 是否超时
    /// </summary>
    public int? Timeout { get; set; }

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
