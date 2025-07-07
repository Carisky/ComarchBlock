using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZasobyGniazdRoboczychView
{
    public int? PobId { get; set; }

    public string? PobKod { get; set; }

    public string? PobNazwa { get; set; }

    public string Oddzial { get; set; } = null!;

    public string? SlwWartoscS { get; set; }

    public int? SlwId { get; set; }

    public int? PofFunkcja { get; set; }

    public int? PofGrupa { get; set; }

    public int PofId { get; set; }
}
