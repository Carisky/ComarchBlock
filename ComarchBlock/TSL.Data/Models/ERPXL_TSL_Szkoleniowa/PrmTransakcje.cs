using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PrmTransakcje
{
    public int PrTId { get; set; }

    public int? PrTKntNumer { get; set; }

    public int? PrTTwrNumer { get; set; }

    public decimal? PrTIlosc { get; set; }

    public decimal? PrTWartosc { get; set; }

    public byte? PrTRodzaj { get; set; }

    public int? PrTData { get; set; }

    public short? PrTDokTyp { get; set; }

    public int? PrTDokNumer { get; set; }

    public short? PrTDokLp { get; set; }
}
