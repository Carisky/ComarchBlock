using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Rozrachunki
{
    public int RozGidtyp { get; set; }

    public int? RozGidfirma { get; set; }

    public int RozGidnumer { get; set; }

    public int RozGidlp { get; set; }

    public int? RozTrpTyp { get; set; }

    public int? RozTrpFirma { get; set; }

    public int? RozTrpNumer { get; set; }

    public int? RozTrpLp { get; set; }

    public int? RozKaztyp { get; set; }

    public int? RozKazfirma { get; set; }

    public int? RozKaznumer { get; set; }

    public int? RozKazlp { get; set; }

    public int RozDtTyp { get; set; }

    public int? RozDtFirma { get; set; }

    public int? RozDtNumer { get; set; }

    public int? RozDtLp { get; set; }

    public int RozCtTyp { get; set; }

    public int? RozCtFirma { get; set; }

    public int? RozCtNumer { get; set; }

    public int? RozCtLp { get; set; }

    public decimal? RozKwota { get; set; }

    public decimal? RozKwotaSys { get; set; }

    public int RozDataOddzialu { get; set; }

    public int RozDataCentrali { get; set; }

    public string? RozWaluta { get; set; }

    public int? RozDtdc { get; set; }

    public int? RozCtdc { get; set; }

    public int RozOpeTypRl { get; set; }

    public int? RozOpeFirmaRl { get; set; }

    public int? RozOpeNumerRl { get; set; }

    public int RozOpeLpRl { get; set; }

    public int RozOpeTypRz { get; set; }

    public int? RozOpeFirmaRz { get; set; }

    public int? RozOpeNumerRz { get; set; }

    public int RozOpeLpRz { get; set; }

    public decimal? RozRk { get; set; }

    public int? RozRkstrona { get; set; }

    public int? RozDataRozliczenia { get; set; }

    public int? RozDataRozrachunku { get; set; }

    public int? RozParId { get; set; }

    public byte? RozWycena { get; set; }
}
