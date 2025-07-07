using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrKodyKnt
{
    public int TkkTwKid { get; set; }

    public int TkkKntNumer { get; set; }

    public byte? TkkDomyslny { get; set; }

    public short TkkKlasaKnt { get; set; }

    public int? TkkCzasModyfikacji { get; set; }

    public virtual KntKarty TkkKntNumerNavigation { get; set; } = null!;

    public virtual TwrKody TkkTwK { get; set; } = null!;
}
