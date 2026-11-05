using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 接口日志表
/// </summary>
public partial class InterfaceLogInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string LogId { get; set; } = null!;

    /// <summary>
    /// 接口名称
    /// </summary>
    public string InterfaceName { get; set; } = null!;

    /// <summary>
    /// 接口编码
    /// </summary>
    public string InterfaceCode { get; set; } = null!;

    /// <summary>
    /// 关键词1
    /// </summary>
    public string? Keyword1 { get; set; }

    /// <summary>
    /// 关键词2
    /// </summary>
    public string? Keyword2 { get; set; }

    /// <summary>
    /// 请求内容
    /// </summary>
    public string? RequestBody { get; set; }

    /// <summary>
    /// 响应内容
    /// </summary>
    public string? ResponseBody { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public int? State { get; set; }

    /// <summary>
    /// 计时
    /// </summary>
    public double? Stopwatch { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
