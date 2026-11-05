using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RoutePolicyTemplate
{
    public string TemplateId { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string? PolicyType { get; set; }

    public string RouteType { get; set; } = null!;

    public string? Description { get; set; }

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }
}
