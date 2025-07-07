using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DeklStr
{
    public int DksDksId { get; set; }

    public int? DksDknId { get; set; }

    public int DksLp { get; set; }

    public string? DksTekst { get; set; }

    public virtual DeklNag? DksDkn { get; set; }
}
