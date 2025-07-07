using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Dpd
{
    public int DpdDpdid { get; set; }

    public int DpdDokumentTyp { get; set; }

    public int DpdDokumentId { get; set; }

    public decimal? DpdSumaKwotZdarzen { get; set; }

    public decimal? DpdSumaKwotRozliczen { get; set; }

    public string? DpdNumer { get; set; }

    public DateTime? DpdData { get; set; }

    public decimal? DpdKwota { get; set; }

    public string? DpdOpis { get; set; }

    public int? DpdKprid { get; set; }

    public int? DpdDekId { get; set; }

    public int DpdRozliczono { get; set; }

    public DateTime? DpdDataKur { get; set; }

    public string? DpdWaluta { get; set; }

    public decimal? DpdKursL { get; set; }

    public decimal? DpdKursM { get; set; }

    public int? DpdKursNumer { get; set; }

    public DateTime? DpdDataWys { get; set; }

    public DateTime? DpdTermin { get; set; }

    public int DpdSkreslony { get; set; }

    public DateTime? DpdDataKorekty { get; set; }
}
