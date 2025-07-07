using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Firma
{
    public int FirFirId { get; set; }

    public int FirNumer { get; set; }

    public string FirWartosc { get; set; } = null!;

    public string FirOpis { get; set; } = null!;
}
