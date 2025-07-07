using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class WszystkoPlopisyOfert
{
    public int WooSekcjaId { get; set; }

    public int? WooGidnumerTwr { get; set; }

    public short? WooUklad { get; set; }

    public string? WooTekst { get; set; }

    public int? WooObraz1 { get; set; }

    public int? WooObraz2 { get; set; }
}
