using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SegmentationProcessesResult
{
    public int SprId { get; set; }

    public int SprProcessId { get; set; }

    public string? SprResult { get; set; }

    public int SprType { get; set; }
}
