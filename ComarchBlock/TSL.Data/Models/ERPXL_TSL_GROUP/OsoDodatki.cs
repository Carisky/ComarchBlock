using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class OsoDodatki
{
    public int OsDId { get; set; }

    public int? OsDOsoNumer { get; set; }

    public int? OsDOsUnumer { get; set; }

    public int? OsDPewid { get; set; }

    public int? OsDOkresOd { get; set; }

    public int? OsDOkresDo { get; set; }

    public decimal? OsDWartosc { get; set; }

    public decimal? OsDWartoscWsk { get; set; }

    public int? OsDOpeWnumer { get; set; }

    public int? OsDCzasWprowadzenia { get; set; }

    public int? OsDOpeMnumer { get; set; }

    public int? OsDCzasModyfikacji { get; set; }
}
