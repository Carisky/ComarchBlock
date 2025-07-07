using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ReklSelem
{
    public int RlsRleid { get; set; }

    public int RlsLp { get; set; }

    public decimal? RlsIlosc { get; set; }

    public short? RlsZrdTyp { get; set; }

    public int? RlsZrdFirma { get; set; }

    public int? RlsZrdNumer { get; set; }

    public short? RlsZrdLp { get; set; }

    public short? RlsSubZrdLp { get; set; }

    public short? RlsZrdDstTyp { get; set; }

    public int? RlsZrdDstNumer { get; set; }

    public int? RlsZrdMagNumer { get; set; }

    public short? RlsCchTyp { get; set; }

    public int? RlsCchNumer { get; set; }

    public short? RlsCchLp { get; set; }

    public string? RlsCecha { get; set; }

    public virtual ReklElem RlsRle { get; set; } = null!;
}
