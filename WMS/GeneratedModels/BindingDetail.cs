using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 托盘库PDA组盘明细表
/// </summary>
public partial class BindingDetail
{
    /// <summary>
    /// 唯一码
    /// </summary>
    public string BindingDetailId { get; set; } = null!;

    /// <summary>
    /// 绑定主ID
    /// </summary>
    public string BindingId { get; set; } = null!;

    /// <summary>
    /// 原箱物料标签二维码
    /// </summary>
    public string? OldMaterialQrcode { get; set; }

    /// <summary>
    /// 原箱号
    /// </summary>
    public string? OldContainerNo { get; set; }

    /// <summary>
    /// 来料单箱装载数量
    /// </summary>
    public decimal? OldNumber { get; set; }

    /// <summary>
    /// 当前单箱装载数量
    /// </summary>
    public decimal? NewNumber { get; set; }
}
