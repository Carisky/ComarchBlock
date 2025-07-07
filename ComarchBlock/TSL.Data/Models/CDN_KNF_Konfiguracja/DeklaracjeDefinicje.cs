using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class DeklaracjeDefinicje
{
    public string DdeResName { get; set; } = null!;

    public string DdeResType { get; set; } = null!;

    public byte[] DdeWartosc { get; set; } = null!;

    public string? DdeSkrot { get; set; }

    public int? DdeRozmiar { get; set; }
}
