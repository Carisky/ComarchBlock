using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AktualizacjeProgram
{
    public string AktPHash { get; set; } = null!;

    public string AktPSciezka { get; set; } = null!;

    public byte[] AktPPlik { get; set; } = null!;

    public bool AktPGrupa { get; set; }

    public int AktPZainstalowano { get; set; }

    public int? AktPKrytyczna { get; set; }

    public bool? AktPGkonfig { get; set; }

    public string AktPTytul { get; set; } = null!;

    public string AktPOpis { get; set; } = null!;

    public int AktPKolejnosc { get; set; }

    public string AktPWersja { get; set; } = null!;
}
