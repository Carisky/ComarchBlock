using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfDashboard
{
    public int DsbId { get; set; }

    public string? DsbName { get; set; }

    public string? DsbXml { get; set; }

    public bool DsbArchival { get; set; }

    public bool DsbType { get; set; }
}
