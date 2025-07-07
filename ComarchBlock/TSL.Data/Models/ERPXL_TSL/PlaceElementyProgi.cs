using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PlaceElementyProgi
{
    public int PepPewid { get; set; }

    public int PepStaz { get; set; }

    public decimal? PepProcent { get; set; }

    public virtual PlaceElementyWyplat PepPew { get; set; } = null!;
}
