using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ReklRealizacja
{
    public int RlrId { get; set; }

    public int? RlrRleid { get; set; }

    public int? RlrRodid { get; set; }

    public string? RlrNazwa { get; set; }

    public string? RlrOpis { get; set; }

    public byte? RlrStanPo { get; set; }

    public byte? RlrStatus { get; set; }

    public short? RlrDokTyp { get; set; }

    public int? RlrDokNumer { get; set; }

    public short? RlrDokLp { get; set; }

    public int? RlrDataWykonania { get; set; }

    public short? RlrOpeTyp { get; set; }

    public int? RlrOpeNumer { get; set; }

    public byte? RlrOpublikowana { get; set; }

    public int? RlrMagNumer { get; set; }

    public int? RlrRodkluczowa { get; set; }

    public int? RlrCzasModyfikacji { get; set; }

    public string? RlrGuid { get; set; }

    public virtual ReklElem? RlrRle { get; set; }
}
