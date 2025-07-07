using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrJm
{
    public short TwJTwrTyp { get; set; }

    public int? TwJTwrFirma { get; set; }

    public int TwJTwrNumer { get; set; }

    public short TwJTwrLp { get; set; }

    public short? TwJKcaTyp { get; set; }

    public int? TwJKcaFirma { get; set; }

    public int? TwJKcaNumer { get; set; }

    public short? TwJKcaLp { get; set; }

    public string? TwJJmZ { get; set; }

    public byte? TwJJmFormat { get; set; }

    public byte? TwJTypJm { get; set; }

    public byte? TwJCalkowita { get; set; }

    public decimal? TwJPrzeliczM { get; set; }

    public decimal? TwJPrzeliczL { get; set; }

    public decimal? TwJProg { get; set; }

    public byte? TwJObowiazek { get; set; }

    public decimal? TwJWaga { get; set; }

    public string? TwJWjm { get; set; }

    public short? TwJWyliczPrzySpr { get; set; }

    public decimal? TwJObjetoscL { get; set; }

    public decimal? TwJObjetoscM { get; set; }

    public decimal? TwJWagaBrutto { get; set; }

    public string? TwJWjmBrutto { get; set; }

    public string? TwJWymJm { get; set; }

    public int? TwJJednostkaLog { get; set; }

    public byte? TwJPulpitKnt { get; set; }

    public byte? TwJMobSpr { get; set; }

    public byte? TwJISklep { get; set; }

    public short? TwJPozycja { get; set; }

    public int TwJId { get; set; }

    public byte? TwJDzielWzwm { get; set; }

    public virtual TwrKarty TwJTwrNumerNavigation { get; set; } = null!;
}
