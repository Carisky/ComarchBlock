using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TrasyNag
{
    public int TsNId { get; set; }

    public int? TsNLokalizacja { get; set; }

    public string? TsNAkronim { get; set; }

    public string? TsNOpis { get; set; }

    public short? TsNKntTyp { get; set; }

    public int? TsNKntNumer { get; set; }

    public short? TsNKierTyp { get; set; }

    public int? TsNKierNumer { get; set; }

    public short? TsNKierLp { get; set; }

    public int? TsNSamId { get; set; }

    public decimal? TsNDlugosc { get; set; }

    public string? TsNNazwa { get; set; }

    public virtual ICollection<TrasyElem> TrasyElems { get; set; } = new List<TrasyElem>();
}
