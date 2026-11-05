using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 库位和容器对应表
/// </summary>
public partial class InventoryLocationInfoCopy1
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string InventoryLocationId { get; set; } = null!;

    /// <summary>
    /// 库存ID
    /// </summary>
    public string InventoryId { get; set; } = null!;

    /// <summary>
    /// 库位ID
    /// </summary>
    public string LocationId { get; set; } = null!;

    /// <summary>
    /// 容器ID
    /// </summary>
    public string ContainerCode { get; set; } = null!;
}
