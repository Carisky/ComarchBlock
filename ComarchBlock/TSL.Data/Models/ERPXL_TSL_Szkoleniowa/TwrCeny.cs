using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class TwrCeny
{
    public short? TwCTwrTyp { get; set; }

    public int? TwCTwrFirma { get; set; }

    public int? TwCTwrNumer { get; set; }

    public short? TwCTwrLp { get; set; }

    public int TwCId { get; set; }

    public string? TwCWaluta { get; set; }

    public short? TwCNrKursu { get; set; }

    public decimal? TwCMarza { get; set; }

    public decimal? TwCZaok { get; set; }

    public decimal? TwCOffset { get; set; }

    public byte? TwCRodzajPodstawy { get; set; }

    public decimal? TwCWartosc { get; set; }

    public byte? TwCAktualizacja { get; set; }

    public byte? TwCPriorytet { get; set; }

    public int? TwCCzasModyfikacji { get; set; }

    public decimal? TwCKosztyDodatkowe { get; set; }

    public short? TwCDokTyp { get; set; }

    public int? TwCDokFirma { get; set; }

    public int? TwCDokNumer { get; set; }

    public short? TwCDokLp { get; set; }

    public int? TwCTcnId { get; set; }

    public int? TwCDataOd { get; set; }

    public short? TwCKntTyp { get; set; }

    public int? TwCKntFirma { get; set; }

    public int? TwCKntNumer { get; set; }

    public short? TwCKntLp { get; set; }

    public int? TwCAktywny { get; set; }

    public virtual TwrKarty? TwCTwrNumerNavigation { get; set; }
}
