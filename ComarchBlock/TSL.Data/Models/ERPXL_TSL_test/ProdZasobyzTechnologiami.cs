using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdZasobyzTechnologiami
{
    public int? PtzId { get; set; }

    public int? PtcTwrNumer { get; set; }

    public int? PteTwrNumer { get; set; }

    public int? PtzTwrNumer { get; set; }

    public string? Kod { get; set; }

    public string? Nazwa { get; set; }

    public string? OpisWersji { get; set; }

    public int? Wersja { get; set; }

    public int Technologia { get; set; }
}
