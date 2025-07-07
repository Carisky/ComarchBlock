using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class WalElem
{
    public string WaESymbol { get; set; } = null!;

    public int WaEKursTs { get; set; }

    public short WaELp { get; set; }

    public decimal WaEKursM { get; set; }

    public decimal WaEKursL { get; set; }

    public string? WaEOpisKursu { get; set; }

    public virtual WalNag WaESymbolNavigation { get; set; } = null!;
}
