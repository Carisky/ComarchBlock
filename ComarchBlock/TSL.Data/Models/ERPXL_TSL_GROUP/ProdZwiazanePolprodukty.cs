using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdZwiazanePolprodukty
{
    public int PzpPzaidwykonany { get; set; }

    public int PzpPzaidplanowany { get; set; }

    public decimal? PzpIlosc { get; set; }
}
