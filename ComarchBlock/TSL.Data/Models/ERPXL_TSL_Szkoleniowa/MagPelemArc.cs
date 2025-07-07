using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagPelemArc
{
    public short? AmaPGidtyp { get; set; }

    public int AmaPGidnumer { get; set; }

    public short AmaPGidlp { get; set; }

    public short AmaPSubGidlp { get; set; }

    public decimal? AmaPIlosc { get; set; }

    public int? AmaPMgAid { get; set; }

    public int? AmaPJednostkaLog { get; set; }

    public int? AmaPTzMlp { get; set; }

    public decimal? AmaPDlugosc { get; set; }

    public decimal? AmaPSzerokosc { get; set; }

    public decimal? AmaPWysokosc { get; set; }

    public virtual MagElem MagElem { get; set; } = null!;
}
