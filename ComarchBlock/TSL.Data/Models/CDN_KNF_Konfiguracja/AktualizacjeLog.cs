using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class AktualizacjeLog
{
    public int AktLId { get; set; }

    public DateTime AktLData { get; set; }

    public string AktLLog { get; set; } = null!;

    public int AktLStatus { get; set; }

    public string AktLHash { get; set; } = null!;

    public string AktLUzytkownik { get; set; } = null!;

    public string AktLTytul { get; set; } = null!;

    public string AktLOpis { get; set; } = null!;
}
