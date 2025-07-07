using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ZlcNag
{
    public short? ZcNGidtyp { get; set; }

    public int? ZcNGidfirma { get; set; }

    public int ZcNGidnumer { get; set; }

    public short? ZcNGidlp { get; set; }

    public short? ZcNZrdTyp { get; set; }

    public int? ZcNZrdFirma { get; set; }

    public int? ZcNZrdNumer { get; set; }

    public short? ZcNZrdLp { get; set; }

    public short? ZcNKntTyp { get; set; }

    public int? ZcNKntFirma { get; set; }

    public int? ZcNKntNumer { get; set; }

    public short? ZcNKntLp { get; set; }

    public short? ZcNKnDtyp { get; set; }

    public int? ZcNKnDfirma { get; set; }

    public int? ZcNKnDnumer { get; set; }

    public short? ZcNKnDlp { get; set; }

    public short? ZcNMaZtyp { get; set; }

    public int? ZcNMaZfirma { get; set; }

    public int? ZcNMaZnumer { get; set; }

    public short? ZcNMaZlp { get; set; }

    public short? ZcNMaDtyp { get; set; }

    public int? ZcNMaDfirma { get; set; }

    public int? ZcNMaDnumer { get; set; }

    public short? ZcNMaDlp { get; set; }

    public short? ZcNZlcRok { get; set; }

    public byte? ZcNZlcMiesiac { get; set; }

    public string? ZcNZlcSeria { get; set; }

    public int? ZcNZlcNumer { get; set; }

    public string? ZcNDokumentObcy { get; set; }

    public short? ZcNOpeTypW { get; set; }

    public int? ZcNOpeFirmaW { get; set; }

    public int? ZcNOpeNumerW { get; set; }

    public short? ZcNOpeLpW { get; set; }

    public short? ZcNOpeTypM { get; set; }

    public int? ZcNOpeFirmaM { get; set; }

    public int? ZcNOpeNumerM { get; set; }

    public short? ZcNOpeLpM { get; set; }

    public short? ZcNOpeTypZ { get; set; }

    public int? ZcNOpeFirmaZ { get; set; }

    public int? ZcNOpeNumerZ { get; set; }

    public short? ZcNOpeLpZ { get; set; }

    public int? ZcNDokId { get; set; }

    public string? ZcNCechaOpis { get; set; }

    public byte? ZcNRealWcalosci { get; set; }

    public int? ZcNDataWystawienia { get; set; }

    public int? ZcNDataRealizacji { get; set; }

    public int? ZcNDataWaznosci { get; set; }

    public int? ZcNDataPotwierdz { get; set; }

    public short? ZcNStan { get; set; }

    public int? ZcNAktywny { get; set; }

    public byte? ZcNDokZwiazane { get; set; }

    public byte? ZcNLkopii { get; set; }

    public byte? ZcNWsk { get; set; }

    public int? ZcNRokMiesiac { get; set; }

    public decimal? ZcNKosztEwidencyjny { get; set; }

    public decimal? ZcNKosztRzeczywisty { get; set; }

    public string? ZcNOpis { get; set; }

    public string? ZcNDziennik { get; set; }

    public byte? ZcNZaksiegowano { get; set; }

    public byte? ZcNNieKsiegowac { get; set; }

    public int? ZcNDataKsiegowania { get; set; }

    public short? ZcNSchtyp { get; set; }

    public int? ZcNSchfirma { get; set; }

    public int? ZcNSchnumer { get; set; }

    public short? ZcNSchlp { get; set; }

    public int? ZcNDataRozliczenia { get; set; }

    public int? ZcNDataAktywacjiRez { get; set; }

    public int? ZcNFrSid { get; set; }

    public string? ZcNUrl { get; set; }

    public short? ZcNAkwTyp { get; set; }

    public int? ZcNAkwFirma { get; set; }

    public int? ZcNAkwNumer { get; set; }

    public short? ZcNAkwLp { get; set; }

    public short? ZcNOpeTypL { get; set; }

    public int? ZcNOpeFirmaL { get; set; }

    public int? ZcNOpeNumerL { get; set; }

    public short? ZcNOpeLpL { get; set; }

    public byte? ZcNWmpm { get; set; }

    public short? ZcNOpiTyp { get; set; }

    public int? ZcNOpiFirma { get; set; }

    public int? ZcNOpiNumer { get; set; }

    public short? ZcNOpiLp { get; set; }

    public byte? ZcNRezerwujZasoby { get; set; }

    public byte? ZcNPriorytetRez { get; set; }

    public int? ZcNGodzinaPotwierdzenia { get; set; }

    public short? ZcNWsSchtyp { get; set; }

    public int? ZcNWsSchnumer { get; set; }

    public byte? ZcNWsStosujSchemat { get; set; }

    public string? ZcNWsDziennik { get; set; }

    public byte? ZcNWsStosujDziennik { get; set; }

    public int? ZcNFrmNumer { get; set; }

    public byte? ZcNRezZasTylkoAktywne { get; set; }

    public virtual ICollection<ZlcElem> ZlcElems { get; set; } = new List<ZlcElem>();
}
