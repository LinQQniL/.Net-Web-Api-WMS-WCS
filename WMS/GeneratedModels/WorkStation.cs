using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 工作站台（翻包台/整箱拣配口/拆零拣配口/入库异常口/出库异常口）
/// 作业模式设置
/// </summary>
public partial class WorkStation
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string StationId { get; set; } = null!;

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
    /// 站点编号
    /// </summary>
    public string StationCode { get; set; } = null!;

    /// <summary>
    /// 当前作业模式
    /// </summary>
    public string? CurrentMode { get; set; }

    /// <summary>
    /// 状态（0无效，1有效）
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 站点电脑IP地址
    /// </summary>
    public string? IpAddress { get; set; }

    /// <summary>
    /// 站点名称
    /// </summary>
    public string? StationName { get; set; }

    /// <summary>
    /// 当前箱型
    /// </summary>
    public string? CurrentContainerType { get; set; }

    public string? CountType { get; set; }
}
