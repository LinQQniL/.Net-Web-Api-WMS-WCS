using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库区表
/// </summary>
public partial class AreaInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string AreaId { get; set; } = null!;

    /// <summary>
    /// 仓库
    /// </summary>
    public string WarehouseId { get; set; } = null!;

    /// <summary>
    /// 区域编码
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// 区域名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public int StateCode { get; set; }

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
