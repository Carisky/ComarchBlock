using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KatStawkiVat
{
    public int KaVKaVid { get; set; }

    public int KaVKatId { get; set; }

    public string KaVKodKraju { get; set; } = null!;

    public decimal KaVStawka { get; set; }

    public short KaVFlaga { get; set; }

    public decimal KaVZrodlowa { get; set; }

    public short KaVRodzaj { get; set; }

    public virtual Kategorie KaVKat { get; set; } = null!;
}
