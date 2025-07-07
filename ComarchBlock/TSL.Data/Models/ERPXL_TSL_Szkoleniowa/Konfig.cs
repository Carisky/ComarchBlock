using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Konfig
{
    public short KonNumer { get; set; }

    public short KonLp { get; set; }

    public byte? KonSystem { get; set; }

    public byte? KonStatus { get; set; }

    public string? KonWartosc { get; set; }

    public string? KonKomentarz { get; set; }

    public byte? KonArchiwalny { get; set; }

    public int? KonCzasModyfikacji { get; set; }

    public int? KonPozycja { get; set; }
}
