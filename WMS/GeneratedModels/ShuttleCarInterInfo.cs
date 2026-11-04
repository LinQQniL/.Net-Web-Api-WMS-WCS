using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ShuttleCarInterInfo
{
    public string LogId { get; set; } = null!;

    public string InterfaceName { get; set; } = null!;

    public string RobotCarTaskType { get; set; } = null!;

    public string? Keyword1 { get; set; }

    public string? Keyword2 { get; set; }

    public string? RequestBody { get; set; }

    public string? ResponseBody { get; set; }

    public int? State { get; set; }

    public double? Stopwatch { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
