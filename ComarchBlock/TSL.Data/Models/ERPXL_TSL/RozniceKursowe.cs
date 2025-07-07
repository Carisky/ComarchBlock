using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RozniceKursowe
{
    public int RknId { get; set; }

    public short? RknRok { get; set; }

    public byte? RknMiesiac { get; set; }

    public string? RknSeria { get; set; }

    public int? RknNumer { get; set; }

    public short? RknDok1Typ { get; set; }

    public int? RknDok1Firma { get; set; }

    public int? RknDok1Numer { get; set; }

    public short? RknDok1Lp { get; set; }

    public decimal? RknDok1KwotaSys { get; set; }

    public short? RknDok2Typ { get; set; }

    public int? RknDok2Firma { get; set; }

    public int? RknDok2Numer { get; set; }

    public short? RknDok2Lp { get; set; }

    public decimal? RknDok2KwotaSys { get; set; }

    public string? RknDokumentObcy { get; set; }

    public byte? RknTyp { get; set; }

    public int? RknDataWyst { get; set; }

    public int? RknDataRozl { get; set; }

    public decimal? RknKwota { get; set; }

    public decimal? RknKwotaRozl { get; set; }

    public byte? RknZnak { get; set; }

    public byte? RknStatus { get; set; }

    public int? RknStatusId { get; set; }

    public byte? RknZaksiegowano { get; set; }

    public byte? RknNieKsiegowac { get; set; }

    public int? RknDataKsiegowania { get; set; }

    public string? RknOpis { get; set; }

    public string? RknDziennik { get; set; }

    public short? RknSchTyp { get; set; }

    public int? RknSchNumer { get; set; }

    public short? RknWsSchtyp { get; set; }

    public int? RknWsSchnumer { get; set; }

    public byte? RknWsStosujSchemat { get; set; }

    public string? RknWsDziennik { get; set; }

    public byte? RknWsStosujDziennik { get; set; }

    public int? RknOpeNumerW { get; set; }

    public int? RknOpeNumerM { get; set; }

    public int? RknAktywny { get; set; }

    public byte? RknBz { get; set; }

    public byte? RknWycena { get; set; }
}
