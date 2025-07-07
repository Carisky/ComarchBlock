using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Konfig
{
    public int KonKonId { get; set; }

    public int KonNumer { get; set; }

    public short KonLp { get; set; }

    public string KonWartosc { get; set; } = null!;

    public string KonOpis { get; set; } = null!;
}
