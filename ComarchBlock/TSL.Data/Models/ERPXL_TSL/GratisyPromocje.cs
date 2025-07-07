using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class GratisyPromocje
{
    public int GprId { get; set; }

    public int? GprPrmId { get; set; }

    public short? GprTwrTyp { get; set; }

    public int? GprTwrNumer { get; set; }

    public int? GprTyp { get; set; }

    public decimal? GprWartosc { get; set; }

    public decimal? GprIlosc { get; set; }

    public string? GprWaluta { get; set; }

    public string? GprFlagaNb { get; set; }

    public string? GprNotatki { get; set; }

    public int? GprPrPid { get; set; }

    public byte? GprDomyslny { get; set; }

    public byte? GprMnoz { get; set; }

    public short? GprPozycja { get; set; }

    public string? GprGuid { get; set; }

    public virtual PrmKarty? GprPrm { get; set; }
}
