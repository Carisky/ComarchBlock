using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// WMS - lista dyspozycji magazynowcyh
/// </summary>
public partial class FktWm
{
    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int WmsfProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Operator. Operator potwierdzający element.
    /// </summary>
    public int WmsfOpeepgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int WmsfStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int WmsfProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension WMSStrukturaMagazynu. Lokalizacja subelementu dyspozycji WMS
    /// </summary>
    public int? WmsfWmsssgid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer. Wskazanie na dokument źródlowy w ERP.
    /// </summary>
    public int? WmsfDokNumerErp { get; set; }

    /// <summary>
    /// Relation to dimension Operator. Operator potwierdzający dokument WMS.
    /// </summary>
    public int WmsfOpegid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int WmsfKntGid { get; set; }

    /// <summary>
    /// Relation to dimension WMSStrukturaMagazynu. Lokalizacja docelowa dyspozycji WMS
    /// </summary>
    public int? WmsfWmssdgid { get; set; }

    /// <summary>
    /// Relation to dimension WMSMagazyn. Magazyn subelementu WMS
    /// </summary>
    public int WmsfWmsmsgid { get; set; }

    /// <summary>
    /// Relation to dimension WMSStrukturaMagazynu. Lokalizacja dla nadwyżki dyspozycji WMS
    /// </summary>
    public int? WmsfWmssnadGid { get; set; }

    /// <summary>
    /// Relation to dimension WMSStrukturaMagazynu. Lokalizacja dyspozycji WMS
    /// </summary>
    public int? WmsfWmssgid { get; set; }

    /// <summary>
    /// Relation to dimension WMSMagazyn. Magazyn wirtualny na dyspozycji WMS.
    /// </summary>
    public int? WmsfWmsemzgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int WmsfStrPrwGid { get; set; }

    /// <summary>
    /// Relation to dimension WMSMagazyn. Magazyn dokumentu WMS.
    /// </summary>
    public int WmsfWmsmgid { get; set; }

    /// <summary>
    /// Relation to dimension WMSMagazyn Magazyn zbiorczy dokumentu WMS
    /// </summary>
    public int? WmsfWmsmcgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data potwierdzenia dokumentu WMS.
    /// </summary>
    public int WmsfCzdzgid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int WmsfBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data realizacji dyspozycji WMS.
    /// </summary>
    public int? WmsfCzdergid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien. Data utworzenia dyspozycji WMS.
    /// </summary>
    public int? WmsfCzdewgid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int WmsfAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension KategorieRynkowe
    /// </summary>
    public int WmsfKatRynGid { get; set; }

    public int WmsfId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int WmsfZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension. Data utworzenia dokumentu.
    /// </summary>
    public int WmsfCzdgid { get; set; }

    public string WmsfOrgId { get; set; } = null!;

    public string? WmsfDirtyOrgId { get; set; }

    public string? WmsfOpis { get; set; }

    public DateTime WmsfTsinsert { get; set; }

    public DateTime WmsfTsupdate { get; set; }

    public int WmsfUpdateSubTransformationId { get; set; }

    public int? WmsfUpdateTransformationId { get; set; }

    public int WmsfInsertSubTransformationId { get; set; }

    public int? WmsfInsertTransformationId { get; set; }

    /// <summary>
    /// Data i czas realizacji dyspozycji
    /// </summary>
    public DateTime? WmsfDataRealizacjiElementu { get; set; }

    /// <summary>
    /// Data i czas utworzenia dyspozycji
    /// </summary>
    public DateTime? WmsfDataUtworzeniaElementu { get; set; }

    /// <summary>
    /// Identyfikator dokumentu WMS.
    /// </summary>
    public int? WmsfDokNumerGid { get; set; }

    /// <summary>
    /// Numer dokumentu w WMS
    /// </summary>
    public string? WmsfDokumentWms { get; set; }

    /// <summary>
    /// Jednostka logistyczna
    /// </summary>
    public string? WmsfJednostkaLogistyczna { get; set; }

    /// <summary>
    /// Jednostka logistyczna docelowa
    /// </summary>
    public string? WmsfJednostkaLogistycznaDocelowa { get; set; }

    /// <summary>
    /// Identyfikator operatora realizaującego dyspozycję
    /// </summary>
    public string? WmsfLoginOperatora { get; set; }

    /// <summary>
    /// Ilość dyzpozycji WMS
    /// </summary>
    public decimal? WmsfMilosc { get; set; }

    /// <summary>
    /// Początkowa ilość dyspozycji WMS
    /// </summary>
    public decimal? WmsfMiloscPoczatkowa { get; set; }

    /// <summary>
    /// Ilość zrealizowana dyspozycji WMS
    /// </summary>
    public decimal? WmsfMiloscZrealizowana { get; set; }

    /// <summary>
    /// Procentowa realizacja dyspozycji WMS
    /// </summary>
    public decimal? WmsfMprocentRealizacjiPozycji { get; set; }

    /// <summary>
    /// Waga brutto na dyspozycji WMS
    /// </summary>
    public decimal? WmsfMwagaBrutto { get; set; }

    /// <summary>
    /// Waga netto na dyspozycji WMS
    /// </summary>
    public decimal? WmsfMwagaNetto { get; set; }

    /// <summary>
    /// Status dyspozycji WMS
    /// </summary>
    public string? WmsfStatusPozycji { get; set; }

    /// <summary>
    /// Identyfikator statusu dyspozycji WMS
    /// </summary>
    public string? WmsfStatusPozycjiId { get; set; }

    /// <summary>
    /// Identyfikator typu dyspozycji WMS
    /// </summary>
    public string? WmsfTypDyspozycjiId { get; set; }

    public virtual WymCzasDzien? WmsfCzderg { get; set; }

    public virtual WymCzasDzien? WmsfCzdewg { get; set; }

    public virtual WymCzasDzien WmsfCzdg { get; set; } = null!;

    public virtual WymCzasDzien WmsfCzdzg { get; set; } = null!;
}
