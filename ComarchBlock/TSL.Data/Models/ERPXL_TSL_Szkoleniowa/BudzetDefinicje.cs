using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BudzetDefinicje
{
    public short BddGidTyp { get; set; }

    public int? BddGidFirma { get; set; }

    public int BddGidNumer { get; set; }

    public short BddGidLp { get; set; }

    public string? BddDefinicja { get; set; }
}
