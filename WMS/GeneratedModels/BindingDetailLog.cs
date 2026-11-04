using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class BindingDetailLog
{
    public string BindingDetailId { get; set; } = null!;

    public string BindingId { get; set; } = null!;

    public string? OldMaterialQrcode { get; set; }

    public string? OldContainerNo { get; set; }

    public decimal? OldNumber { get; set; }

    public decimal? NewNumber { get; set; }
}
