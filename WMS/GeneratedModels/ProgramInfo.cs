using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

/// <summary>
/// WCS程序表
/// </summary>
public partial class ProgramInfo
{
    /// <summary>
    /// WCS程序表ID
    /// </summary>
    public string ProgramId { get; set; } = null!;

    /// <summary>
    /// 程序代码
    /// </summary>
    public string ProgramCode { get; set; } = null!;

    /// <summary>
    /// 程序名称
    /// </summary>
    public string ProgramName { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

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
