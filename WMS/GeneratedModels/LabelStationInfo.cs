using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 标签打印机配置
/// </summary>
public partial class LabelStationInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 工位编号
    /// </summary>
    public string StationId { get; set; } = null!;

    /// <summary>
    /// IP端口
    /// </summary>
    public string Ipport { get; set; } = null!;

    /// <summary>
    /// 贴标机名称
    /// </summary>
    public string? LabelName { get; set; }

    /// <summary>
    /// IP地址
    /// </summary>
    public string Ipaddress { get; set; } = null!;

    /// <summary>
    /// 创建人
    /// </summary>
    public string Creator { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public short IsCheckEnable { get; set; }

    /// <summary>
    /// 打印机名称
    /// </summary>
    public string? Remark { get; set; }
}
