using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class LogKeyWord
{
    public string KeyWordId { get; set; } = null!;

    public string KeyWord { get; set; } = null!;

    public string KeyWordEn { get; set; } = null!;

    public string KeyWordThird { get; set; } = null!;

    public string? KeyWordGroup { get; set; }

    public int? Sequence { get; set; }

    public short? StateCode { get; set; }

    public string? AlternateData { get; set; }

    public string? Creator { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? Updator { get; set; }

    public DateTime? UpdateTime { get; set; }
}
