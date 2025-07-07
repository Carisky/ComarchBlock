using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Aplikacje
{
    public string AplKod { get; set; } = null!;

    public string? AplNazwa { get; set; }

    public string? AplProducent { get; set; }

    public string? AplWersja { get; set; }

    public string? AplNumSer { get; set; }

    public int? AplDataRej { get; set; }

    public int? AplOfset { get; set; }

    public byte? AplStatus { get; set; }

    public int? AplPlatformy { get; set; }
}
