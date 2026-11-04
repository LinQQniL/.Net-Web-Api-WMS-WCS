using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class VLocationUsageRate
{
    public long? LocationUsageId { get; set; }

    public string? Name { get; set; }

    public string? AreaName { get; set; }

    public long? OccupiedLocations { get; set; }

    public long? EmptyOccupiedLocations { get; set; }

    public long? FullOccupiedLocations { get; set; }

    public long? EmptyLocations { get; set; }

    public int? TotalLocations { get; set; }

    public string? LocationUtilizationRate { get; set; }

    public string? EmptyLocationUtilizationRate { get; set; }

    public string? FullLocationUtilizationRate { get; set; }
}
