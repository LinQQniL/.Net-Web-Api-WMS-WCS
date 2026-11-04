using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class RoutePolicyDetail
{
    public string PolicyDetailId { get; set; } = null!;

    public string? TemplateId { get; set; }

    public string PolicyDetailName { get; set; } = null!;

    public string MethodType { get; set; } = null!;

    public string MethodName { get; set; } = null!;

    public string? Parameter { get; set; }

    public int Sequence { get; set; }

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }
}
