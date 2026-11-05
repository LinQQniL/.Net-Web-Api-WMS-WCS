using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 数据字典
/// </summary>
public partial class DictDataInfo
{
    /// <summary>
    /// 字典标识
    /// </summary>
    public string DictId { get; set; } = null!;

    /// <summary>
    /// 字典编码
    /// </summary>
    public string DictCode { get; set; } = null!;

    /// <summary>
    /// 字典名称
    /// </summary>
    public string DictName { get; set; } = null!;

    /// <summary>
    /// 字典分组
    /// </summary>
    public string? DictGroup { get; set; }

    /// <summary>
    /// 字典类型
    /// </summary>
    public string? DictType { get; set; }

    /// <summary>
    /// 字典排序
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public short? StateCode { get; set; }

    /// <summary>
    /// 备用
    /// </summary>
    public string? AlternateData { get; set; }

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
