using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktSaldaAgregat
{
    public int SKontoid { get; set; }

    public int? SCzdid { get; set; }

    public int? SCzmid { get; set; }

    public int? SBudzetid { get; set; }

    public string? SKonto { get; set; }

    public int? SKontoparid { get; set; }

    public decimal? SMkwotaWn { get; set; }

    public decimal? SMkwotaMa { get; set; }
}
