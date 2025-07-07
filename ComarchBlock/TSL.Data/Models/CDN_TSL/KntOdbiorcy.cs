using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KntOdbiorcy
{
    public int OdbOdbId { get; set; }

    public int? OdbKntOdbId { get; set; }

    public int? OdbOdbKntId { get; set; }

    public byte OdbDomyslny { get; set; }
}
