using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraCykliczne
{
    public int TrCGidnumer { get; set; }

    public int TrCJestCykliczna { get; set; }

    public int? TrCGrupa { get; set; }

    public DateTime? TrCDataUtw { get; set; }

    public DateTime? TrCDataMod { get; set; }
}
