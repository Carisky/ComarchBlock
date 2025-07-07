using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class MagPelem
{
    public short? MaPGidtyp { get; set; }

    public int MaPGidnumer { get; set; }

    public short MaPGidlp { get; set; }

    public short MaPSubGidlp { get; set; }

    public decimal? MaPIlosc { get; set; }

    public int? MaPMgAid { get; set; }

    public int? MaPJednostkaLog { get; set; }

    public int? MaPTzMlp { get; set; }

    public decimal? MaPDlugosc { get; set; }

    public decimal? MaPSzerokosc { get; set; }

    public decimal? MaPWysokosc { get; set; }
}
