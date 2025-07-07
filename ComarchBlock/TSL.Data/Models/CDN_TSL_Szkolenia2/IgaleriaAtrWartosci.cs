using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class IgaleriaAtrWartosci
{
    public int IgawIgawid { get; set; }

    public int IgawIgaid { get; set; }

    public int IgawTwrId { get; set; }

    public string IgawWartosc { get; set; } = null!;

    public int IgawIgdwid { get; set; }

    public virtual Towary IgawTwr { get; set; } = null!;
}
