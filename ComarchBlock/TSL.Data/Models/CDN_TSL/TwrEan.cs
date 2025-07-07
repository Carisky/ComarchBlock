using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TwrEan
{
    public int TwETwEid { get; set; }

    public int TwETwrId { get; set; }

    public string TwEEan { get; set; } = null!;

    public string TwEOpis { get; set; } = null!;

    public byte TwEDomyslny { get; set; }

    public string TwEJm { get; set; } = null!;

    public virtual Towary TwETwr { get; set; } = null!;
}
