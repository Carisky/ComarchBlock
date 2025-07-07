using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PlatnosciNaDzien
{
    public int? PndDzien { get; set; }

    public int? PndTyp { get; set; }

    public int? PndGidTyp { get; set; }

    public int? PndGidNumer { get; set; }

    public int? PndGidLp { get; set; }

    public int? PndSpiTyp { get; set; }

    public int? PndSpiNumer { get; set; }

    public string? PndWaluta { get; set; }

    public decimal? PndRazem { get; set; }

    public decimal? PndRazemW { get; set; }
}
