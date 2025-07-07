using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TempRozrachunki
{
    public int? RozTrpTyp { get; set; }

    public int? RozTrpNumer { get; set; }

    public int? RozTrpLp { get; set; }

    public decimal? RozKwotaSys { get; set; }

    public int? RozDataRozliczenia { get; set; }
}
