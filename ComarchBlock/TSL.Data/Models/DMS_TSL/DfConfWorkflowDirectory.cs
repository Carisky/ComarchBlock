using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfWorkflowDirectory
{
    public int DdwId { get; set; }

    public string DdwName { get; set; } = null!;

    public DateTime? DdwCreateDate { get; set; }

    public int? DdwDdwid { get; set; }

    public int? DdwPosition { get; set; }

    public bool? DdwArchival { get; set; }
}
