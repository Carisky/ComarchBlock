using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TwrStawkiVat
{
    public int TwVTwVid { get; set; }

    public int TwVTwrId { get; set; }

    public string TwVKodKraju { get; set; } = null!;

    public decimal TwVStawka { get; set; }

    public short TwVFlaga { get; set; }

    public decimal TwVZrodlowa { get; set; }

    public virtual Towary TwVTwr { get; set; } = null!;
}
