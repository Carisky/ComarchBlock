using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class PoleceniaTozsame
{
    public int PotId { get; set; }

    public int? PotPglid { get; set; }

    public string? PotTresc { get; set; }

    public virtual PoleceniaGlowne? PotPgl { get; set; }
}
