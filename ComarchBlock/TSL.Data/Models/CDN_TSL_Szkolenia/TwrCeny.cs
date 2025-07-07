using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class TwrCeny
{
    public int TwCTwCid { get; set; }

    public int TwCTwrId { get; set; }

    public int TwCTwCnumer { get; set; }

    public byte TwCTyp { get; set; }

    public decimal TwCWartosc { get; set; }

    public string TwCWaluta { get; set; } = null!;

    public byte TwCAktualizacja { get; set; }

    public decimal TwCZaokraglenie { get; set; }

    public decimal TwCMarza { get; set; }

    public decimal TwCMarzaWstu { get; set; }

    public decimal TwCOffset { get; set; }

    public short? TwCTwrTyp { get; set; }

    public int? TwCTwrFirma { get; set; }

    public int? TwCTwrNumer { get; set; }

    public short? TwCTwrLp { get; set; }

    public int TwCDokId { get; set; }

    public decimal TwCWartoscZakOld { get; set; }

    public int TwCPunkty { get; set; }

    public virtual Towary TwCTwr { get; set; } = null!;
}
