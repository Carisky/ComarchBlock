using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class RoObjectsType
{
    public int DfhId { get; set; }

    public string DfhName { get; set; } = null!;

    public DateTime? DfhCreateDate { get; set; }

    public string? DfhPrefix { get; set; }

    public bool? DfhArchives { get; set; }
}
