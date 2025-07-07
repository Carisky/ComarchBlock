using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AnlWstawki
{
    public byte AnWStandardowa { get; set; }

    public int AnWId { get; set; }

    public string AnWNazwa { get; set; } = null!;

    public string AnWTekst { get; set; } = null!;

    public string? AnWWersja { get; set; }

    public string? AnWAutor { get; set; }

    public string? AnWHaslo { get; set; }

    public string? AnWHasloChk { get; set; }

    public string? AnWEdycja { get; set; }

    public int? AnWOpeZalId { get; set; }

    public DateTime AnWTsZal { get; set; }

    public int? AnWOpeModId { get; set; }

    public DateTime AnWTsMod { get; set; }

    public string AnWOpeModKod { get; set; } = null!;

    public string AnWOpeModNazwisko { get; set; } = null!;

    public string AnWOpeZalKod { get; set; } = null!;

    public string AnWOpeZalNazwisko { get; set; } = null!;
}
