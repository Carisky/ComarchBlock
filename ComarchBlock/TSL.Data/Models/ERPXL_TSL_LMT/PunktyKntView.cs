using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PunktyKntView
{
    public int? PkvKntNumer { get; set; }

    public int PkvObiNumer { get; set; }

    public short? PkvObiTyp { get; set; }

    public string? PkvDokument { get; set; }

    public int? PkvDataWystawienia { get; set; }

    public decimal? PkvWartoscNetto { get; set; }

    public decimal? PkvWartoscBrutto { get; set; }

    public decimal? PkvPunktyIlosc { get; set; }

    public int? PkvPunktyDataPrzyznania { get; set; }

    public int PkvPunktyNagroda { get; set; }
}
