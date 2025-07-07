using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Konfig
{
    public int KonNumer { get; set; }

    public int KonLp { get; set; }

    public int KonSystem { get; set; }

    public int KonStatus { get; set; }

    public string KonWartosc { get; set; } = null!;

    public string KonKomentarz { get; set; } = null!;
}
