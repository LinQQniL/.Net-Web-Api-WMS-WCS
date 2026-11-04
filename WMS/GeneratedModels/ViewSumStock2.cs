using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class ViewSumStock2
{
    public string? MaterialCode { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? MaterialName { get; set; }

    public string? AreaCode { get; set; }

    public decimal? CurStockQty { get; set; }

    public decimal? SumStockQty { get; set; }

    public decimal? SumAllocateQty { get; set; }

    public decimal? MinSafty { get; set; }

    public decimal? MaxSafty { get; set; }
}
