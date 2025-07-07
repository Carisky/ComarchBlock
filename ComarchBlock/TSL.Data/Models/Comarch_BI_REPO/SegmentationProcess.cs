using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SegmentationProcess
{
    public int SpId { get; set; }

    public int SpSegmentationObjectId { get; set; }

    public DateTime? SpStartDate { get; set; }

    public DateTime? SpEndDate { get; set; }

    public int SpState { get; set; }

    public string? SpDescription { get; set; }
}
