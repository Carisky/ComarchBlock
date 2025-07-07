using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class IgaleriaAtrybuty
{
    public int IgaIgaid { get; set; }

    public int IgaIgkid { get; set; }

    public string IgaNazwa { get; set; } = null!;

    public int IgaTyp { get; set; }

    public string IgaJednostka { get; set; } = null!;

    public byte IgaAktywny { get; set; }

    public byte IgaDowolnaWartosc { get; set; }
}
