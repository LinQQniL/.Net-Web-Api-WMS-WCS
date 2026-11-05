using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class VMinSaftyStockInfo
{
    public string? MaterialCode { get; set; }

    public string? MaterialName { get; set; }

    public decimal? SumStockQty { get; set; }

    public decimal? SumAllocateQty { get; set; }

    public decimal? MinSafty { get; set; }
}
