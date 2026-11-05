using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class AgvSynvHisStation
{
    public string Id { get; set; } = null!;

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string StationCode { get; set; } = null!;

    public string WorkStationType { get; set; } = null!;

    public string Status { get; set; } = null!;
}
