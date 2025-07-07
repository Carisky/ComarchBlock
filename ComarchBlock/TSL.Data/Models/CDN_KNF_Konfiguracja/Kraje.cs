using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Kraje
{
    public int KraKraId { get; set; }

    public string KraNazwa { get; set; } = null!;

    public string? KraKod { get; set; }
}
