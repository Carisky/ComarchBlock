using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TraCyklPropKntWzorce
{
    public int TrCGrupa { get; set; }

    public int TrCWzrId { get; set; }

    public int TrCPodId { get; set; }

    public int TrCPropStatus { get; set; }

    public int? TrCAktywna { get; set; }

    public DateTime? TrCDataUtw { get; set; }

    public DateTime? TrCDataMod { get; set; }
}
