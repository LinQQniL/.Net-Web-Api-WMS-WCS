using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RouteSectionTemplate
{
    public string SectionTemplateId { get; set; } = null!;

    public string RouteId { get; set; } = null!;

    public string EquipmentCode { get; set; } = null!;

    public string RouteType { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string TemplateId { get; set; } = null!;

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }
}
