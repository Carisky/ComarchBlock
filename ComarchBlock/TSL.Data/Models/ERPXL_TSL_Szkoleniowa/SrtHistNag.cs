using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrtHistNag
{
    public short ShnGidtyp { get; set; }

    public int? ShnGidfirma { get; set; }

    public int ShnGidnumer { get; set; }

    public short? ShnGidlp { get; set; }

    public short? ShnOpeTyp { get; set; }

    public int? ShnOpeFirma { get; set; }

    public int? ShnOpeNumer { get; set; }

    public short? ShnOpeLp { get; set; }

    public short? ShnSchTyp { get; set; }

    public int? ShnSchFirma { get; set; }

    public int? ShnSchNumer { get; set; }

    public short? ShnSchLp { get; set; }

    public short? ShnKorTyp { get; set; }

    public int? ShnKorFirma { get; set; }

    public int? ShnKorNumer { get; set; }

    public short? ShnKorLp { get; set; }

    public string? ShnSeria { get; set; }

    public int? ShnData { get; set; }

    public short? ShnRokO { get; set; }

    public int? ShnNr { get; set; }

    public string? ShnPoprzedniSymbDok { get; set; }

    public short? ShnPoprzedniGidtyp { get; set; }

    public decimal? ShnKwotaInw { get; set; }

    public decimal? ShnPodstawaAm { get; set; }

    public decimal? ShnKwotaUm { get; set; }

    public decimal? ShnKwotaAm { get; set; }

    public string? ShnCechaOpis { get; set; }

    public byte? ShnZaksiegowano { get; set; }

    public byte? ShnNieKsiegowac { get; set; }

    public int? ShnDataKsiegowania { get; set; }

    public string? ShnDziennik { get; set; }

    public int? ShnAktywny { get; set; }

    public string? ShnOpis { get; set; }

    public int? ShnDokId { get; set; }

    public byte? ShnMsObow { get; set; }

    public byte? ShnMsObowAm { get; set; }

    public short? ShnWsSchtyp { get; set; }

    public int? ShnWsSchnumer { get; set; }

    public byte? ShnWsStosujSchemat { get; set; }

    public string? ShnWsDziennik { get; set; }

    public byte? ShnWsStosujDziennik { get; set; }

    public byte? ShnUjecieOpisA { get; set; }

    public string? ShnMiejsceUzyt { get; set; }

    public short? ShnPrcTyp { get; set; }

    public int? ShnPrcFirma { get; set; }

    public int? ShnPrcNumer { get; set; }

    public short? ShnPrcLp { get; set; }

    public int? ShnDataObowiazywania { get; set; }

    public decimal? ShnKwotaInwSys { get; set; }

    public decimal? ShnPodsawaAmSys { get; set; }

    public decimal? ShnKwotaUmSys { get; set; }

    public decimal? ShnKwotaAmSys { get; set; }

    public int? ShnItnid { get; set; }

    public decimal? ShnPodstawaAmTor3 { get; set; }

    public decimal? ShnPodstawaAmTor4 { get; set; }

    public decimal? ShnPodstawaAmTor5 { get; set; }

    public decimal? ShnKwotaAmTor3 { get; set; }

    public decimal? ShnKwotaAmTor4 { get; set; }

    public decimal? ShnKwotaAmTor5 { get; set; }

    public byte? ShnMsObowAmTor3 { get; set; }

    public byte? ShnMsObowAmTor4 { get; set; }

    public byte? ShnMsObowAmTor5 { get; set; }

    public decimal? ShnPodstawaAmTor3Sys { get; set; }

    public decimal? ShnPodstawaAmTor4Sys { get; set; }

    public decimal? ShnPodstawaAmTor5Sys { get; set; }

    public decimal? ShnKwotaAmTor3Sys { get; set; }

    public decimal? ShnKwotaAmTor4Sys { get; set; }

    public decimal? ShnKwotaAmTor5Sys { get; set; }

    public virtual ICollection<SrtHistElem> SrtHistElems { get; set; } = new List<SrtHistElem>();
}
