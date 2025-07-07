using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KntZasoby
{
    public short? KnZTwrTyp { get; set; }

    public int? KnZTwrFirma { get; set; }

    public int? KnZTwrNumer { get; set; }

    public short? KnZTwrLp { get; set; }

    public short KnZKntTyp { get; set; }

    public int? KnZKntFirma { get; set; }

    public int KnZKntNumer { get; set; }

    public short? KnZKntLp { get; set; }

    public short KnZDstTyp { get; set; }

    public int? KnZDstFirma { get; set; }

    public int KnZDstNumer { get; set; }

    public short? KnZDstLp { get; set; }

    public short? KnZMagTyp { get; set; }

    public int? KnZMagFirma { get; set; }

    public int? KnZMagNumer { get; set; }

    public short? KnZMagLp { get; set; }

    public short? KnZTrEtyp { get; set; }

    public int? KnZTrEfirma { get; set; }

    public int? KnZTrEnumer { get; set; }

    public short? KnZTrElp { get; set; }

    public decimal? KnZKsiegowaNetto { get; set; }

    public decimal? KnZRzeczywistaNetto { get; set; }

    public decimal? KnZIlosc { get; set; }

    public int? KnZTstamp { get; set; }

    public short? KnZDoZwrotu { get; set; }

    public int? KnZTerminZwrotu { get; set; }

    public virtual KntTowary? KntTowary { get; set; }
}
