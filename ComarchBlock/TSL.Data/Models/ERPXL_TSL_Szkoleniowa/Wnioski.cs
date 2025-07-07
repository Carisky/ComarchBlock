using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Wnioski
{
    public short? WnoGidtyp { get; set; }

    public int? WnoGidfirma { get; set; }

    public int WnoGidnumer { get; set; }

    public short? WnoGidlp { get; set; }

    public short? WnoTyp { get; set; }

    public short? WnoStan { get; set; }

    public int? WnoPrcnumer { get; set; }

    public int? WnoOpenumerWpr { get; set; }

    public int? WnoPrcNumerWpr { get; set; }

    public int? WnoTstampWpr { get; set; }

    public byte? WnoZatwierdzono { get; set; }

    public int? WnoOpenumerZatw { get; set; }

    public int? WnoTstampZatw { get; set; }

    public byte? WnoOdrzucono { get; set; }

    public int? WnoOpenumerAnul { get; set; }

    public int? WnoTstampAnul { get; set; }

    public string? WnoPowodAnul { get; set; }

    public string? WnoOpis { get; set; }

    public decimal? WnoKwota { get; set; }

    public string? WnoWaluta { get; set; }

    public int? WnoFrsnumer { get; set; }

    public short? WnoRok { get; set; }

    public byte? WnoMiesiac { get; set; }

    public string? WnoSeria { get; set; }

    public int? WnoNumer { get; set; }

    public int? WnoDlgNumer { get; set; }

    public short? WnoDlgLp { get; set; }

    public int? WnoKazNumer { get; set; }

    public int? WnoTstampPow { get; set; }

    public int? WnoOpenumerMod { get; set; }

    public int? WnoPrcNumerMod { get; set; }

    public int? WnoTstampMod { get; set; }

    public int? WnoEprcnumerZatw { get; set; }

    public int? WnoEprcnumerAnul { get; set; }

    public string? WnoEprcnumerZapisuKb { get; set; }

    public int? WnoAktywny { get; set; }

    public byte? WnoTrybWstawiania { get; set; }

    public string? WnoImie { get; set; }

    public string? WnoNazwisko { get; set; }
}
