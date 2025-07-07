using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Tkselem
{
    public short TksGidtyp { get; set; }

    public int? TksGidfirma { get; set; }

    public int TksGidnumer { get; set; }

    public short TksGidlp { get; set; }

    public short TksSubGidlp { get; set; }

    public short? TksDstTyp { get; set; }

    public int? TksDstFirma { get; set; }

    public int? TksDstNumer { get; set; }

    public short? TksDstLp { get; set; }

    public short? TksMagTyp { get; set; }

    public int? TksMagFirma { get; set; }

    public int? TksMagNumer { get; set; }

    public short? TksMagLp { get; set; }

    public short? TksZwrTyp { get; set; }

    public int? TksZwrFirma { get; set; }

    public int? TksZwrNumer { get; set; }

    public short? TksZwrLp { get; set; }

    public short? TksSubZwrLp { get; set; }

    public short? TksRezTyp { get; set; }

    public int? TksRezFirma { get; set; }

    public int? TksRezNumer { get; set; }

    public short? TksRezLp { get; set; }

    public int? TksTkntstamp { get; set; }

    public decimal? TksIlosc { get; set; }

    public short? TksCchTyp { get; set; }

    public int? TksCchFirma { get; set; }

    public int? TksCchNumer { get; set; }

    public short? TksCchLp { get; set; }

    public string? TksCecha { get; set; }

    public short? TksDoZwrotu { get; set; }

    public int? TksTerminZwrotu { get; set; }

    public decimal? TksKosztKsiegowy { get; set; }

    public decimal? TksKosztRzeczywisty { get; set; }

    public virtual Tkelem Tkelem { get; set; } = null!;
}
