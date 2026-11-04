using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RouteSetting
{
    public string RouteId { get; set; } = null!;

    public string RouteCode { get; set; } = null!;

    public string RouteName { get; set; } = null!;

    public string? Description { get; set; }

    public string TaskType { get; set; } = null!;

    public string ProgramId { get; set; } = null!;

    /// <summary>
    /// 最后一次使用时间
    /// </summary>
    public DateTime? LastUseTime { get; set; }

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }
}
