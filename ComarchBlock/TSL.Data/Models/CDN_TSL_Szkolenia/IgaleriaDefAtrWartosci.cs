using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class IgaleriaDefAtrWartosci
{
    public int IgdwIgdwid { get; set; }

    public int IgdwIgaid { get; set; }

    public string IgdwWartosc { get; set; } = null!;

    public byte IgdwAktywna { get; set; }
}
