using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RefPromocje
{
    public int RprId { get; set; }

    public int? RprTprid { get; set; }

    public string? RprNazwa { get; set; }

    public byte? RprTyp { get; set; }

    public decimal? RprWartosc { get; set; }

    public virtual TwrPromocje? RprTpr { get; set; }
}
