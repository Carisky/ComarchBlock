using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfApaccess
{
    public int ApaApdid { get; set; }

    public int ApaDcdid { get; set; }

    public bool ApaArchival { get; set; }

    public bool? ApaCanEditDocument { get; set; }

    public virtual DfConfApdictionary ApaApd { get; set; } = null!;

    public virtual DfConfOsdictionary ApaDcd { get; set; } = null!;
}
