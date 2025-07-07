using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class DtsDeklaracjeElem
{
    public int DdeId { get; set; }

    public int? DdeDdNid { get; set; }

    public int? DdePozycja { get; set; }

    public decimal? DdeKwotaL { get; set; }

    public decimal? DdeKwotaM { get; set; }

    public string? DdeNazwa { get; set; }

    public string? DdeOpis { get; set; }

    public virtual DtsDeklaracjeNag? DdeDdN { get; set; }
}
