using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class UmlPrzedmioty
{
    public int UlpUlnid { get; set; }

    public short UlpLp { get; set; }

    public decimal? UlpWartoscPrzedmiotu { get; set; }

    public decimal? UlpOplataWstKwota { get; set; }

    public decimal? UlpOplataWstProcent { get; set; }

    public decimal? UlpWartoscWykKwota { get; set; }

    public decimal? UlpWartoscWykProcent { get; set; }

    public decimal? UlpSumaRatNetto { get; set; }

    public int? UlpSrtnumer { get; set; }

    public int? UlpShenumer { get; set; }

    public short? UlpShelp { get; set; }

    public byte? UlpOdliczeniaVat { get; set; }

    public int? UlpOgraniczenieOdl { get; set; }

    public decimal? UlpWartoscPrzedmiotuSys { get; set; }

    public decimal? UlpOplataWstKwotaSys { get; set; }

    public decimal? UlpWartoscWykKwotaSys { get; set; }

    public decimal? UlpSumaRatNettoSys { get; set; }

    public string? UlpWaluta { get; set; }

    public short? UlpNrKursu { get; set; }

    public decimal? UlpKursM { get; set; }

    public decimal? UlpKursL { get; set; }

    public virtual UmlNag UlpUln { get; set; } = null!;
}
