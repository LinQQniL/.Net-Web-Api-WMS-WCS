using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RouteSection
{
    public string SectionId { get; set; } = null!;

    public string RouteId { get; set; } = null!;

    public string SectionName { get; set; } = null!;

    public string EquipmentCode { get; set; } = null!;

    public string EquipmentType { get; set; } = null!;

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool IsNoScan { get; set; }
}
