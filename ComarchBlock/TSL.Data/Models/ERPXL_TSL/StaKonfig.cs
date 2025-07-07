using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class StaKonfig
{
    public short? StKStaTyp { get; set; }

    public int? StKStaFirma { get; set; }

    public int StKStaNumer { get; set; }

    public short StKStaLp { get; set; }

    public short StKNumer { get; set; }

    public string? StKWartosc { get; set; }

    public byte? StKSystem { get; set; }

    public virtual StaKarty StKStaNumerNavigation { get; set; } = null!;
}
