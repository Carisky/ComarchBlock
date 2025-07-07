using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WalKontum
{
    public int WaKWaKid { get; set; }

    public string WaKSymbol { get; set; } = null!;

    public string? WaKKontoWn { get; set; }

    public string? WaKKontoMa { get; set; }
}
