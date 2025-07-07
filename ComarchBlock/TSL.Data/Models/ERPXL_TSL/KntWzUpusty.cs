using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntWzUpusty
{
    public short WkuGrpTyp { get; set; }

    public int? WkuGrpFirma { get; set; }

    public int WkuGrpNumer { get; set; }

    public short WkuGrpLp { get; set; }

    public short? WkuTwGtyp { get; set; }

    public int? WkuTwGfirma { get; set; }

    public int? WkuTwGnumer { get; set; }

    public short? WkuTwGlp { get; set; }

    public decimal? WkuUpust { get; set; }

    public string? WkuUpustWzor { get; set; }

    public string? WkuSymbol { get; set; }

    public short? WkuNrKursu { get; set; }

    public string? WkuFlagaNb { get; set; }

    public virtual KntWzorce KntWzorce { get; set; } = null!;
}
