using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DelegacjeElem
{
    public short? DgeGidtyp { get; set; }

    public int? DgeGidfirma { get; set; }

    public int DgeGidnumer { get; set; }

    public short DgeGidlp { get; set; }

    public short? DgeRodzaj { get; set; }

    public string? DgeWaluta { get; set; }

    public string? DgeKraj { get; set; }

    public int? DgeStawkaNumer { get; set; }

    public int? DgeLiczbaSniadan { get; set; }

    public int? DgeLiczbaObiadow { get; set; }

    public int? DgeLiczbaKolacji { get; set; }

    public decimal? DgeKwotaDiety { get; set; }

    public decimal? DgeKwotaRyczaltDojazd { get; set; }

    public decimal? DgeKwotaRyczaltNocleg { get; set; }

    public int? DgeTstampRozp { get; set; }

    public int? DgeTstampZak { get; set; }

    public byte? DgePokazKomentarz { get; set; }

    public string? DgeKomentarz { get; set; }
}
