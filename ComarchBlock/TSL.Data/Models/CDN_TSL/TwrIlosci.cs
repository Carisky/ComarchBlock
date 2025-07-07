using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TwrIlosci
{
    public int TwITwIid { get; set; }

    public int TwITwrId { get; set; }

    public int? TwIMagId { get; set; }

    public DateTime? TwIData { get; set; }

    public decimal TwIIlosc { get; set; }

    public decimal TwIWartosc { get; set; }

    public decimal TwIBraki { get; set; }

    public decimal TwIRezerwacje { get; set; }

    public decimal TwIZamowienia { get; set; }

    public decimal TwIRezerwacjeZlecenia { get; set; }

    public virtual Magazyny? TwIMag { get; set; }

    public virtual Towary TwITwr { get; set; } = null!;
}
