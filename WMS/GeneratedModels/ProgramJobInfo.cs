using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ProgramJobInfo
{
    /// <summary>
    /// WCS程序JopID
    /// </summary>
    public string ProgramJobId { get; set; } = null!;

    /// <summary>
    /// WCS程序ID
    /// </summary>
    public string ProgramId { get; set; } = null!;

    /// <summary>
    /// WCS程序Jop名称
    /// </summary>
    public string ProgramJobName { get; set; } = null!;

    public string? CronExp { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 是否启用
    /// </summary>
    public bool? IsEnable { get; set; }

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
