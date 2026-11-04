using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 工厂表
/// </summary>
public partial class Factory
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string FactoryId { get; set; } = null!;

    /// <summary>
    /// 工厂编码
    /// </summary>
    public string FactoryNo { get; set; } = null!;

    /// <summary>
    /// 是否分厂
    /// </summary>
    public short IsBranchFactory { get; set; }

    /// <summary>
    /// 立库仓库编号
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// 立库标识
    /// </summary>
    public string? SysCode { get; set; }

    /// <summary>
    /// BYD仓库编号
    /// </summary>
    public string? WhNumber { get; set; }

    /// <summary>
    /// 立库区域编号
    /// </summary>
    public string? AreaCode { get; set; }

    /// <summary>
    /// 关联的分厂代码
    /// </summary>
    public string? ChildFactoryNo { get; set; }
}
