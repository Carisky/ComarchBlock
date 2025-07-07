using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfReportsAccess
{
    public int RpaRptid { get; set; }

    public int RpaDcdid { get; set; }

    public bool RpaArchival { get; set; }

    public virtual DfReport RpaRpt { get; set; } = null!;
}
