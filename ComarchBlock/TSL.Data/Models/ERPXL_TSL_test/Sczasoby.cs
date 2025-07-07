using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Sczasoby
{
    public short? SzDstTyp { get; set; }

    public int? SzDstFirma { get; set; }

    public int SzDstNumer { get; set; }

    public short SzDstLp { get; set; }

    public short? SzSctyp { get; set; }

    public int? SzScfirma { get; set; }

    public int? SzScnumer { get; set; }

    public short? SzSclp { get; set; }

    public short? SzTwrTyp { get; set; }

    public int? SzTwrFirma { get; set; }

    public int? SzTwrNumer { get; set; }

    public short? SzTwrLp { get; set; }

    public decimal? SzIlosc { get; set; }

    public decimal? SzWartosc { get; set; }

    public string? SzWaluta { get; set; }

    public decimal? SzKosztKraj { get; set; }

    public decimal? SzKosztZagr { get; set; }

    public string? SzWalutaKosztuKrajowego { get; set; }

    public string? SzWalutaKosztuZagranicznego { get; set; }

    public string? SzKrajPoch { get; set; }

    public int? SzDataP { get; set; }

    public virtual SkladyCelne? SzScnumerNavigation { get; set; }
}
