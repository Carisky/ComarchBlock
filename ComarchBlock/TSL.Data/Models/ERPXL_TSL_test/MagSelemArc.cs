using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class MagSelemArc
{
    public short? AmaSGidtyp { get; set; }

    public int? AmaSGidfirma { get; set; }

    public int AmaSGidnumer { get; set; }

    public short AmaSGidlp { get; set; }

    public short AmaSSubGidlp { get; set; }

    public short? AmaSDstTyp { get; set; }

    public int? AmaSDstFirma { get; set; }

    public int? AmaSDstNumer { get; set; }

    public short? AmaSDstLp { get; set; }

    public short? AmaSMagTyp { get; set; }

    public int? AmaSMagFirma { get; set; }

    public int? AmaSMagNumer { get; set; }

    public short? AmaSMagLp { get; set; }

    public short? AmaSZrdTyp { get; set; }

    public int? AmaSZrdFirma { get; set; }

    public int? AmaSZrdNumer { get; set; }

    public short? AmaSZrdLp { get; set; }

    public short? AmaSSubZrdLp { get; set; }

    public short? AmaSTwrTyp { get; set; }

    public int? AmaSTwrFirma { get; set; }

    public int? AmaSTwrNumer { get; set; }

    public short? AmaSTwrLp { get; set; }

    public decimal? AmaSIlosc { get; set; }

    public int? AmaSTrnTstamp { get; set; }

    public short? AmaSZlcTyp { get; set; }

    public int? AmaSZlcFirma { get; set; }

    public int? AmaSZlcNumer { get; set; }

    public short? AmaSZlcLp { get; set; }

    public virtual MagElem MagElem { get; set; } = null!;
}
