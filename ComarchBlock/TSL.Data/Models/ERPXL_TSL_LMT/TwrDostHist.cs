using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrDostHist
{
    public int TdhId { get; set; }

    public short? TdhTwrTyp { get; set; }

    public int? TdhTwrNumer { get; set; }

    public short? TdhTwrLp { get; set; }

    public short? TdhKlasaKnt { get; set; }

    public short? TdhZrdTyp { get; set; }

    public int? TdhZrdNumer { get; set; }

    public short? TdhOpeTyp { get; set; }

    public int? TdhOpeNumer { get; set; }

    public string? TdhKodOrgKnt { get; set; }

    public decimal? TdhCena { get; set; }

    public string? TdhWaluta { get; set; }

    public string? TdhJmZ { get; set; }

    public int? TdhCzas { get; set; }

    public string? TdhNotatki { get; set; }

    public int? TdhDataAktualizacji { get; set; }

    public short? TdhKlasaKntOrg { get; set; }

    public byte? TdhDomyslny { get; set; }

    public string? TdhKodDodatkowyKnt { get; set; }

    public string? TdhNazwaKnt { get; set; }

    public int? TdhDataOd { get; set; }
}
