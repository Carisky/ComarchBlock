using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class PlaceWskazniki
{
    public int PwsId { get; set; }

    public byte? PwsTyp { get; set; }

    public int? PwsDataOd { get; set; }

    public int? PwsDataDo { get; set; }

    public byte? PwsPredefiniowany { get; set; }

    public string? PwsKod { get; set; }

    public string? PwsNazwa { get; set; }

    public decimal? PwsWartosc1 { get; set; }

    public decimal? PwsWartosc2 { get; set; }

    public decimal? PwsWartosc3 { get; set; }

    public string? PwsWartoscS1 { get; set; }

    public string? PwsWartoscS2 { get; set; }

    public int? PwsOpeWnumer { get; set; }

    public int? PwsCzasWprowadzenia { get; set; }

    public int? PwsOpeMnumer { get; set; }

    public int? PwsCzasModyfikacji { get; set; }
}
