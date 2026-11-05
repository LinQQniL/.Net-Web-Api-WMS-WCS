using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 用户操作日志表
/// </summary>
public partial class UserLogInfo
{
    /// <summary>
    /// 用户操作日志表ID
    /// </summary>
    public string UserLogId { get; set; } = null!;

    /// <summary>
    /// 操作方法名
    /// </summary>
    public string? ActionName { get; set; }

    /// <summary>
    /// 操作类型(0、添加1、删除2、修改)
    /// </summary>
    public short? ActionType { get; set; }

    /// <summary>
    /// 操作表名
    /// </summary>
    public string TableName { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 操作用户--token
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// 接口地址(URL)
    /// </summary>
    public string ActionUrl { get; set; } = null!;

    /// <summary>
    /// 请求方IP地址
    /// </summary>
    public string? ActionIp { get; set; }

    /// <summary>
    /// 请求方法
    /// </summary>
    public string? ActionMethod { get; set; }

    /// <summary>
    /// 请求参数
    /// </summary>
    public string? ActionPara { get; set; }

    /// <summary>
    /// 请求体中的所有值
    /// </summary>
    public string? ActionBody { get; set; }

    /// <summary>
    /// 请求时间
    /// </summary>
    public DateTime? RequestTime { get; set; }

    /// <summary>
    /// 响应结果
    /// </summary>
    public string? ActionResult { get; set; }

    /// <summary>
    /// 响应时间
    /// </summary>
    public DateTime? ResponseTime { get; set; }

    /// <summary>
    /// 响应时长
    /// </summary>
    public double? Stopwatch { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }
}
