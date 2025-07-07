using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TwrOpisy
{
    public short? TwOTwrTyp { get; set; }

    public int? TwOTwrFirma { get; set; }

    public int TwOTwrNumer { get; set; }

    public short TwOTwrLp { get; set; }

    public byte? TwOTyp { get; set; }

    public int TwOJezyk { get; set; }

    public string? TwOOpis { get; set; }

    public int? TwOCzasModyfikacji { get; set; }

    public virtual TwrKarty TwOTwrNumerNavigation { get; set; } = null!;
}
