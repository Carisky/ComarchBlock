using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AktualizacjeBaza
{
    public string AktBHash { get; set; } = null!;

    public string AktBSciezka { get; set; } = null!;

    public byte[] AktBPlik { get; set; } = null!;

    public int AktBZainstalowano { get; set; }

    public bool AktBKonfig { get; set; }

    public int? AktBKrytyczna { get; set; }

    public string AktBTytul { get; set; } = null!;

    public string AktBOpis { get; set; } = null!;

    public int AktBKolejnosc { get; set; }

    public string AktBWersja { get; set; } = null!;
}
