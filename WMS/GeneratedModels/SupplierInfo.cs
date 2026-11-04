using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class SupplierInfo
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 供应商编码
    /// </summary>
    public string SupplierCode { get; set; } = null!;

    /// <summary>
    /// 供应商名称
    /// </summary>
    public string SupplierName { get; set; } = null!;

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public bool? IsDeleted { get; set; }
}
