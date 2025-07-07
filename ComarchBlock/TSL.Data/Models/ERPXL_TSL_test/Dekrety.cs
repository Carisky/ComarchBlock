using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Dekrety
{
    public short? DtGidtyp { get; set; }

    public int? DtGidfirma { get; set; }

    public int DtGidnumer { get; set; }

    public short DtGidlp { get; set; }

    public byte DtDc { get; set; }

    public byte? DtZnak { get; set; }

    public string? DtBufor { get; set; }

    public string? DtDziennik { get; set; }

    public short? DtRok { get; set; }

    public short? DtMiesiac { get; set; }

    public short? DtDzien { get; set; }

    public string? DtKonto { get; set; }

    public int? DtFirmaKonta { get; set; }

    public decimal? DtKwota { get; set; }

    public decimal? DtPozostaje { get; set; }

    public string? DtWaluta { get; set; }

    public short? DtNrKursu { get; set; }

    public int? DtTermin { get; set; }

    public int? DtDataRozliczenia { get; set; }

    public byte? DtRozliczony { get; set; }

    public byte? DtNierozliczony { get; set; }

    public byte? DtKorektaBo { get; set; }

    public int? DtDataOddzialu { get; set; }

    public int? DtDataCentrali { get; set; }

    public byte? DtBezKontroli { get; set; }

    public int? DtKksnumer { get; set; }

    public byte DtWalutaObca { get; set; }

    public decimal? DtKursKwota { get; set; }

    public int? DtDataDekr { get; set; }

    public virtual DziennikElem DziennikElem { get; set; } = null!;
}
