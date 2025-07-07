using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class CrmwizytyRptTwr
{
    public short CwtCwetyp { get; set; }

    public int CwtCwenumer { get; set; }

    public short CwtCwelp { get; set; }

    public int CwtCrdid { get; set; }

    public int CwtTwrNumer { get; set; }

    public byte? CwtObecny { get; set; }

    public decimal? CwtIlosc { get; set; }

    public string? CwtJm { get; set; }

    public decimal? CwtCena { get; set; }

    public int? CwtEkspozycja { get; set; }

    public short? CwtFacing { get; set; }

    public short? CwtKntTyp { get; set; }

    public int? CwtKntNumer { get; set; }

    public string? CwtCrkwartosc1 { get; set; }

    public string? CwtCrkwartosc2 { get; set; }

    public string? CwtCrkwartosc3 { get; set; }

    public string? CwtCrkwartosc4 { get; set; }

    public string? CwtCrkwartosc5 { get; set; }

    public virtual TwrKarty CwtTwrNumerNavigation { get; set; } = null!;
}
