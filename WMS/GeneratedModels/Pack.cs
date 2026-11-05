using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 包装代码主数据表
/// </summary>
public partial class Pack
{
    /// <summary>
    /// 唯一标识
    /// </summary>
    public string Packid { get; set; } = null!;

    /// <summary>
    /// 工厂代码
    /// </summary>
    public string Werks { get; set; } = null!;

    /// <summary>
    /// 仓库号
    /// </summary>
    public string WhNumber { get; set; } = null!;

    /// <summary>
    /// 立库标识
    /// </summary>
    public string Sysnod { get; set; } = null!;

    /// <summary>
    /// 包装代码
    /// </summary>
    public string PackCode { get; set; } = null!;

    /// <summary>
    /// 包装类型
    /// </summary>
    public string PackType { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? PackDescribe { get; set; }

    /// <summary>
    /// 长度
    /// </summary>
    public decimal? Length { get; set; }

    /// <summary>
    /// 宽度
    /// </summary>
    public decimal? Width { get; set; }

    /// <summary>
    /// 高度
    /// </summary>
    public decimal? Height { get; set; }

    /// <summary>
    /// 重量
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// 材质
    /// </summary>
    public string? MaterialQuality { get; set; }

    /// <summary>
    /// 格口(无细分时默认是1)
    /// </summary>
    public string? Slot { get; set; }

    /// <summary>
    /// 编辑人
    /// </summary>
    public string? Editor { get; set; }

    /// <summary>
    /// 编辑时间
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// 创建人
    /// </summary>
    public string? CreateUser { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public string? State { get; set; }
}
