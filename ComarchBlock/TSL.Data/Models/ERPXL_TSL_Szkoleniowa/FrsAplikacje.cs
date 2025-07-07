using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class FrsAplikacje
{
    public int FrAId { get; set; }

    public int? FrAFrsId { get; set; }

    public short? FrAObiTyp { get; set; }

    public int? FrAObiNumer { get; set; }

    public byte? FrANieWysylaj { get; set; }

    public byte? FrATypAplikacji { get; set; }

    public short? FrACenaDomyslna { get; set; }

    public byte? FrAAdmin { get; set; }
}
