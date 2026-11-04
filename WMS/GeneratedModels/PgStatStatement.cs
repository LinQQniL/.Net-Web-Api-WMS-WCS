using System;
using System.Collections.Generic;

namespace WMS.WebApi.GeneratedModels;

public partial class PgStatStatement
{
    public uint? Userid { get; set; }

    public uint? Dbid { get; set; }

    public string? Query { get; set; }

    public long? Calls { get; set; }

    public double? TotalTime { get; set; }

    public long? Rows { get; set; }

    public long? SharedBlksHit { get; set; }

    public long? SharedBlksRead { get; set; }

    public long? SharedBlksDirtied { get; set; }

    public long? SharedBlksWritten { get; set; }

    public long? LocalBlksHit { get; set; }

    public long? LocalBlksRead { get; set; }

    public long? LocalBlksDirtied { get; set; }

    public long? LocalBlksWritten { get; set; }

    public long? TempBlksRead { get; set; }

    public long? TempBlksWritten { get; set; }

    public double? BlkReadTime { get; set; }

    public double? BlkWriteTime { get; set; }
}
