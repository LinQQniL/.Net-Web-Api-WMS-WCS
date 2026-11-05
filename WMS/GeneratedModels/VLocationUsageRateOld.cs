using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class VLocationUsageRateOld
{
    public long? LocationUsageId { get; set; }

    public string? Name { get; set; }

    public string? AreaName { get; set; }

    public long? OccupiedLocations { get; set; }

    public long? EmptyOccupiedLocations { get; set; }

    public long? EmptyLocations { get; set; }

    public long? DisabledLocations { get; set; }

    public long? TotalLocations { get; set; }

    public decimal? LocationUtilizationRate { get; set; }

    public long? MaterialCount { get; set; }
}
