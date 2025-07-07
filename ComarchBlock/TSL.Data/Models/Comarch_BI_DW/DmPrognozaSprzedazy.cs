using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DmPrognozaSprzedazy
{
    public int SprCzdid { get; set; }

    public int SprProdId { get; set; }

    public string PrdNazwa { get; set; } = null!;

    public string ProdRodzaj { get; set; } = null!;

    public int SprMprzychod { get; set; }

    public int SprMmarza { get; set; }

    public int SprMilosc { get; set; }
}
