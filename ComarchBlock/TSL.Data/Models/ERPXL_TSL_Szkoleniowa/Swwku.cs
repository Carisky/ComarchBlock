using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Swwku
{
    public string SwwSymbol { get; set; } = null!;

    public decimal? SwwStawkaVat { get; set; }

    public byte? SwwFlagaVat { get; set; }

    public string? SwwOpis { get; set; }
}
