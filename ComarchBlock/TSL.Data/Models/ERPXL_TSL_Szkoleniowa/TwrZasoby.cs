using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrZasoby
{
    public short? TwZDstTyp { get; set; }

    public int? TwZDstFirma { get; set; }

    public int TwZDstNumer { get; set; }

    public short? TwZDstLp { get; set; }

    public short? TwZTwrTyp { get; set; }

    public int? TwZTwrFirma { get; set; }

    public int? TwZTwrNumer { get; set; }

    public short? TwZTwrLp { get; set; }

    public short? TwZMagTyp { get; set; }

    public int? TwZMagFirma { get; set; }

    public int TwZMagNumer { get; set; }

    public short? TwZMagLp { get; set; }

    public int? TwZDataP { get; set; }

    public decimal? TwZKsiegowaNetto { get; set; }

    public decimal? TwZRzeczywistaNetto { get; set; }

    public string? TwZEan { get; set; }

    public string? TwZPolozenie { get; set; }

    public int? TwZDataW { get; set; }

    public decimal? TwZKosztKsiegowy { get; set; }

    public decimal? TwZKosztRzeczywisty { get; set; }

    public decimal? TwZIlSpr { get; set; }

    public decimal? TwZIlMag { get; set; }

    public decimal? TwZIlosc { get; set; }

    public decimal? TwZIloscWms { get; set; }

    public virtual Magazyny TwZMagNumerNavigation { get; set; } = null!;
}
