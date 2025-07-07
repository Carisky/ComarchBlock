using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokumentyKbview
{
    public int DkbDkbid { get; set; }

    public int DkbTypDokumentuKb { get; set; }

    public int? DkbBraId { get; set; }

    public short? DkbPodmiotTyp { get; set; }

    public int? DkbPodmiotId { get; set; }

    public DateTime DkbDataDok { get; set; }

    public DateTime DkbTermin { get; set; }

    public DateTime DkbDataReal { get; set; }

    public string? DkbNumerPelny { get; set; }

    public string? DkbNumer { get; set; }

    public decimal DkbKwota { get; set; }

    public decimal? DkbKwotaKierunkowa { get; set; }

    public decimal DkbKwotaRoz { get; set; }

    public string DkbWaluta { get; set; } = null!;

    public string DkbWalutaDok { get; set; } = null!;

    public DateTime DkbDataKur { get; set; }

    public int DkbKursNumer { get; set; }

    public decimal DkbKursL { get; set; }

    public decimal DkbKursM { get; set; }

    public decimal DkbKwotaSys { get; set; }

    public decimal? DkbKwotaKierunkowaSys { get; set; }

    public decimal DkbKwotaRozSys { get; set; }

    public short DkbKierunek { get; set; }

    public short DkbRozliczono { get; set; }

    public short DkbRozliczono2 { get; set; }

    public int DkbStan { get; set; }

    public DateTime? DkbDataRoz { get; set; }

    public string DkbOpis { get; set; } = null!;

    public string DkbKontoPrzeciwstawne { get; set; } = null!;

    public int DkbWynagrodzenie { get; set; }

    public int? DkbKatId { get; set; }

    public int? DkbWindykacjaSchematId { get; set; }

    public int? DkbDokumentId { get; set; }

    public short? DkbDokumentTyp { get; set; }
}
