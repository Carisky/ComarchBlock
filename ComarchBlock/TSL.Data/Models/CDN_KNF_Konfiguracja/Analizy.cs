using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Analizy
{
    public byte AnlStandardowa { get; set; }

    public int AnlId { get; set; }

    public string AnlNazwa { get; set; } = null!;

    public byte AnlTyp { get; set; }

    public string AnlZapytanie { get; set; } = null!;

    public byte? AnlTypObslugiZaznaczen { get; set; }

    public byte AnlTypPrezentacji { get; set; }

    public string AnlDefinicjaPrezentacji { get; set; } = null!;

    public string? AnlDefinicjaPrezentacjiWizard { get; set; }

    public string? AnlWarunek { get; set; }

    public string? AnlWarunekAuto { get; set; }

    public short? AnlTimeout { get; set; }

    public string? AnlOpis { get; set; }

    public string? AnlWersja { get; set; }

    public string? AnlAutor { get; set; }

    public string? AnlHaslo { get; set; }

    public string? AnlHasloChk { get; set; }

    public string? AnlLayout { get; set; }

    public string? AnlEdycja { get; set; }

    public int? AnlOpeZalId { get; set; }

    public DateTime AnlTsZal { get; set; }

    public int? AnlOpeModId { get; set; }

    public DateTime AnlTsMod { get; set; }

    public string AnlOpeModKod { get; set; } = null!;

    public string AnlOpeModNazwisko { get; set; } = null!;

    public string AnlOpeZalKod { get; set; } = null!;

    public string AnlOpeZalNazwisko { get; set; } = null!;
}
