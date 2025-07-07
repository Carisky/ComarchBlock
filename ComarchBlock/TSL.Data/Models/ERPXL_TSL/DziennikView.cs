using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DziennikView
{
    public short? DzkGidtyp { get; set; }

    public int? DzkGidfirma { get; set; }

    public int DzkGidnumer { get; set; }

    public short? DzkGidlp { get; set; }

    public string? DzkDziennik { get; set; }

    public short? DzkRok { get; set; }

    public short? DzkMiesiac { get; set; }

    public short? DzkDzien { get; set; }

    public int? DzkDataDekr { get; set; }

    public int? DzkDataWyst { get; set; }

    public int? DzkDataOper { get; set; }

    public int? DzkRmnumer { get; set; }

    public string? DzkBufor { get; set; }

    public int? DzkOkrPoczatek { get; set; }

    public string? DzkOkrSymbol { get; set; }

    public string? DzkOpis { get; set; }

    public string? DzkDokumentZrodlowy { get; set; }

    public int? DzkNumerDokumentu { get; set; }

    public string? DzkKomentarz { get; set; }

    public int? DzkTs { get; set; }

    public int? DzkAktywny { get; set; }

    public short? DzkOpeWtyp { get; set; }

    public int? DzkOpeWfirma { get; set; }

    public int? DzkOpeWnumer { get; set; }

    public short? DzkOpeWlp { get; set; }

    public short? DzkOpeZtyp { get; set; }

    public int? DzkOpeZfirma { get; set; }

    public int? DzkOpeZnumer { get; set; }

    public short? DzkOpeZlp { get; set; }

    public byte? DzkStorno { get; set; }

    public byte? DzkProsty { get; set; }

    public string? DzkIdentyfikator { get; set; }

    public string? DelOpis { get; set; }

    public byte? DtKorektaBo { get; set; }

    public int? DtDataOddzialu { get; set; }

    public int? DtDataCentrali { get; set; }

    public byte? DtBezKontroli { get; set; }

    public string? DtKonto { get; set; }

    public decimal? DtKwota { get; set; }

    public decimal? DtPozostaje { get; set; }

    public string? DtWaluta { get; set; }

    public short? DtNrKursu { get; set; }

    public int? DtTermin { get; set; }

    public int? DtDataRozliczenia { get; set; }

    public byte? DtRozliczony { get; set; }

    public byte? DtNierozliczony { get; set; }

    public string? CtKonto { get; set; }

    public decimal? CtKwota { get; set; }

    public decimal? CtPozostaje { get; set; }

    public string? CtWaluta { get; set; }

    public short? CtNrKursu { get; set; }

    public int? CtTermin { get; set; }

    public int? CtDataRozliczenia { get; set; }

    public byte? CtRozliczony { get; set; }

    public byte? CtNierozliczony { get; set; }
}
