using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WalNag
{
    public string WaNSymbol { get; set; } = null!;

    public string WaNKontoPlus { get; set; } = null!;

    public string WaNKontoMinus { get; set; } = null!;

    public string WaNNazwa { get; set; } = null!;

    public string WaNPanstwo { get; set; } = null!;

    public string WaNSlownie1 { get; set; } = null!;

    public string WaNSlownie2 { get; set; } = null!;

    public int WaNAktywna { get; set; }

    public int WaNWsk { get; set; }

    public string WaNSymbolEmu { get; set; } = null!;

    public decimal WaNParytet { get; set; }
}
