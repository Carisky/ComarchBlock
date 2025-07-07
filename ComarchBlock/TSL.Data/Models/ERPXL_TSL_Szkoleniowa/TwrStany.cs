using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrStany
{
    public int TwsData { get; set; }

    public short TwsTwrTyp { get; set; }

    public int? TwsTwrFirma { get; set; }

    public int TwsTwrNumer { get; set; }

    public short? TwsTwrLp { get; set; }

    public short TwsMagTyp { get; set; }

    public int? TwsMagFirma { get; set; }

    public int TwsMagNumer { get; set; }

    public short? TwsMagLp { get; set; }

    public decimal? TwsKsiegowaNetto { get; set; }

    public decimal? TwsRzeczywistaNetto { get; set; }

    public decimal? TwsIlSpr { get; set; }

    public decimal? TwsIlMag { get; set; }
}
