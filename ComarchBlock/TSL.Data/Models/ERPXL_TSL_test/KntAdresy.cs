using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class KntAdresy
{
    public short? KnAGidtyp { get; set; }

    public int? KnAGidfirma { get; set; }

    public int KnAGidnumer { get; set; }

    public short? KnAGidlp { get; set; }

    public short? KnAKntTyp { get; set; }

    public int? KnAKntFirma { get; set; }

    public int? KnAKntNumer { get; set; }

    public short? KnAKntLp { get; set; }

    public int? KnADataArc { get; set; }

    public string? KnAAkronim { get; set; }

    public byte? KnAWysylkowy { get; set; }

    public string? KnANazwa1 { get; set; }

    public string? KnANazwa2 { get; set; }

    public string? KnANazwa3 { get; set; }

    public string? KnAKodP { get; set; }

    public string? KnAMiasto { get; set; }

    public string? KnAUlica { get; set; }

    public string? KnAAdres { get; set; }

    public string? KnANipE { get; set; }

    public string? KnANip { get; set; }

    public string? KnANipPrefiks { get; set; }

    public string? KnARegon { get; set; }

    public string? KnAPesel { get; set; }

    public string? KnAKontoDostawcy { get; set; }

    public string? KnAKontoOdbiorcy { get; set; }

    public string? KnAKraj { get; set; }

    public string? KnAPowiat { get; set; }

    public string? KnAGmina { get; set; }

    public string? KnAWojewodztwo { get; set; }

    public int? KnARegionCrm { get; set; }

    public string? KnAGln { get; set; }

    public string? KnATelefon1 { get; set; }

    public string? KnATelefon2 { get; set; }

    public string? KnAFax { get; set; }

    public string? KnAModem { get; set; }

    public string? KnATelex { get; set; }

    public string? KnAEmail { get; set; }

    public short? KnABnkTyp { get; set; }

    public int? KnABnkFirma { get; set; }

    public int? KnABnkNumer { get; set; }

    public short? KnABnkLp { get; set; }

    public string? KnANrRachunku { get; set; }

    public int? KnALastModL { get; set; }

    public decimal? KnAOdleglosc { get; set; }

    public short? KnANrb { get; set; }

    public short? KnANiePublikuj { get; set; }

    public short? KnADomyslny { get; set; }

    public string? KnADokumentTozsamosci { get; set; }

    public int? KnADataWydania { get; set; }

    public string? KnAOrganWydajacy { get; set; }

    public byte? KnARolnikRyczaltowy { get; set; }

    public byte? KnAStanPostep { get; set; }

    public byte? KnAPlatnikVat { get; set; }

    public decimal? KnAGpssz { get; set; }

    public decimal? KnAGpsdl { get; set; }

    public int? KnAGpsdataPobrania { get; set; }

    public int? KnAGpsgodzinaPobrania { get; set; }

    public int? KnAKnaPierwotny { get; set; }

    public int? KnAKnaArchiwizowanego { get; set; }

    public short? KnAOsoba { get; set; }

    public string? KnAOpis { get; set; }

    public byte? KnAAnonim { get; set; }

    public byte? KnAAdresBank { get; set; }

    public byte? KnAMetodaKasowa { get; set; }

    public string? KnAGuid { get; set; }

    public string? KnAGuiddane { get; set; }

    public int? KnAVatDataRejestracji { get; set; }

    public int? KnAVatDataOdmowy { get; set; }

    public int? KnAVatDataPrzywrocenia { get; set; }

    public int? KnAVatDataUsuniecia { get; set; }

    public int? KnAVatDataSprawdzenia { get; set; }

    public string? KnAKrajSiedziby { get; set; }

    public short? KnATypPos { get; set; }

    public string? KnAGuidemail { get; set; }

    public string? KnAGuidtelefon { get; set; }

    public string? KnAUlicaCdc { get; set; }

    public string? KnANrDomuCdc { get; set; }

    public string? KnANrMieszkaniaCdc { get; set; }

    public string? KnAKrajCdc { get; set; }

    public string? KnAKodPcdc { get; set; }

    public string? KnAMiastoCdc { get; set; }

    public string? KnARegionCdc { get; set; }

    public byte? KnACharsetAnsi { get; set; }

    public virtual ICollection<PodElemDok> PodElemDoks { get; set; } = new List<PodElemDok>();
}
