using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Krst
{
    public int KrstKrstid { get; set; }

    public byte KrstStandardowa { get; set; }

    public string KrstSymbol { get; set; } = null!;

    public string? KrstNazwa { get; set; }

    public string KrstPozycja { get; set; } = null!;

    public decimal KrstStawka { get; set; }

    public byte KrstNieaktywna { get; set; }

    public string KrstStaraWersja { get; set; } = null!;
}
