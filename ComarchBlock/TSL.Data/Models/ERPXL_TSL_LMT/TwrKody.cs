using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrKody
{
    public int TwKId { get; set; }

    public byte? TwKTypKodu { get; set; }

    public string? TwKKod { get; set; }

    public string? TwKJm { get; set; }

    public string? TwKOpis { get; set; }

    public byte? TwKRodzaj { get; set; }

    public int? TwKTwrNumer { get; set; }

    public byte? TwKPochodzenie { get; set; }

    public byte? TwKDomyslny { get; set; }

    public int? TwKCzasModyfikacji { get; set; }

    public virtual TwrKarty? TwKTwrNumerNavigation { get; set; }

    public virtual ICollection<TwrKodyKnt> TwrKodyKnts { get; set; } = new List<TwrKodyKnt>();
}
