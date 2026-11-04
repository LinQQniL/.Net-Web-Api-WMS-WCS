using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// 字段设置表
/// </summary>
public partial class FieldSetting
{
    /// <summary>
    /// 字段设置表ID
    /// </summary>
    public string FieldId { get; set; } = null!;

    /// <summary>
    /// 表名
    /// </summary>
    public string TableName { get; set; } = null!;

    /// <summary>
    /// 字段名
    /// </summary>
    public string FieldName { get; set; } = null!;

    /// <summary>
    /// 字段名称
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 字段英文名称
    /// </summary>
    public string? EnTitle { get; set; }

    public string? ThirdTitle { get; set; }

    /// <summary>
    /// 字段类型
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// 排序编号
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// 默认值
    /// </summary>
    public string? DefaultValue { get; set; }

    /// <summary>
    /// 字段宽度
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// 选择类型
    /// </summary>
    public string? SelectType { get; set; }

    /// <summary>
    /// 选择设置信息
    /// </summary>
    public string? SelectSetting { get; set; }

    /// <summary>
    /// 链接页面
    /// </summary>
    public string? Linkage { get; set; }

    /// <summary>
    /// 显示格式
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// 是否主键
    /// </summary>
    public bool? PrimaryKey { get; set; }

    /// <summary>
    /// 是否必须
    /// </summary>
    public bool? Required { get; set; }

    /// <summary>
    /// 是否显示
    /// </summary>
    public string? VisibleType { get; set; }

    /// <summary>
    /// 是否可用
    /// </summary>
    public string? EnableType { get; set; }

    /// <summary>
    /// 是否保存
    /// </summary>
    public bool? IsSave { get; set; }

    /// <summary>
    /// 查询类型
    /// </summary>
    public string? QueryType { get; set; }

    /// <summary>
    /// 查询默认值
    /// </summary>
    public string? QueryDefault { get; set; }

    /// <summary>
    /// 排序类型
    /// </summary>
    public string? SortType { get; set; }

    /// <summary>
    /// 排序编号
    /// </summary>
    public int? SortSequence { get; set; }

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
    /// 是否汇总，1是，0否
    /// </summary>
    public bool? IsSummary { get; set; }
}
