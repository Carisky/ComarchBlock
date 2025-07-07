using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WalElem
{
    public string WaESymbol { get; set; } = null!;

    public int? WaEKursTs { get; set; }

    public int WaELp { get; set; }

    public decimal WaEKursM { get; set; }

    public decimal WaEKursL { get; set; }
}
