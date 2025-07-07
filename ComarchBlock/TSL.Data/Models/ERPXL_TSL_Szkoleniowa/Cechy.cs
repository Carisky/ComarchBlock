using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Cechy
{
    public short? CchGidtyp { get; set; }

    public int? CchGidfirma { get; set; }

    public int CchGidnumer { get; set; }

    public short CchGidlp { get; set; }

    public string? CchCecha { get; set; }

    public string? CchOpis { get; set; }

    public byte? CchAktywna { get; set; }

    public byte? CchWsk { get; set; }

    public int? CchCzasModyfikacji { get; set; }

    public byte? CchISklep { get; set; }

    public virtual CechyKlasy CchGidnumerNavigation { get; set; } = null!;
}
