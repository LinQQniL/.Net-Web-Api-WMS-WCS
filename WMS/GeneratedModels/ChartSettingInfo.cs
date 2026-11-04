using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ChartSettingInfo
{
    public string ChartId { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public int Sort { get; set; }

    public string ChartType { get; set; } = null!;

    public string ChartSpan { get; set; } = null!;

    public string Sql { get; set; } = null!;

    public bool? ShowLegend { get; set; }
}
