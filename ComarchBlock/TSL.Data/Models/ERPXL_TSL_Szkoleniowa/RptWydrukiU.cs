using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class RptWydrukiU
{
    public int RpWuId { get; set; }

    public string? RpWuWarunek { get; set; }

    public string? RpWuWarunekAuto { get; set; }

    public int? RpWuKopiaElektroniczna { get; set; }
}
