using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 站台类型配置
/// </summary>
public partial class WorkStationTypeSet
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string WorkStationTypeSetId { get; set; } = null!;

    /// <summary>
    /// 站点编号
    /// </summary>
    public string StationCode { get; set; } = null!;

    /// <summary>
    /// 工作站台类型（人工叉车翻包出库台/整箱拣配口/拆零拣配口/入库异常口/出库异常口/非生产领料口）
    /// </summary>
    public string WorkStationType { get; set; } = null!;

    /// <summary>
    /// Agv目标地点或区域
    /// </summary>
    public string? AgvTargetAddress { get; set; }

    /// <summary>
    /// 出库是1
    /// 次上报还是2次上报(下拉选择3项，未设置，1次，2次1
    /// </summary>
    public short? PostBydWmstimes { get; set; }

    /// <summary>
    /// 状态（0无效，1有效）
    /// </summary>
    public short? Status { get; set; }
}
