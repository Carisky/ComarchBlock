using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Magazyny WMS-owe.
/// </summary>
public partial class WymWmsmagazyn
{
    /// <summary>
    /// Relation to dimension Pracownik. Osobo odpowiedzialna za magazyn
    /// </summary>
    public int? WmsmOdpowiedzialnyId { get; set; }

    public int WmsmRowId { get; set; }

    public int WmsmId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int WmsmZrodgid { get; set; }

    public string WmsmOrgId { get; set; } = null!;

    public string WmsmDirtyOrgId { get; set; } = null!;

    public string? WmsmNazwa { get; set; }

    public string? WmsmOpis { get; set; }

    public string? WmsmParDirtyOrgId { get; set; }

    public string? WmsmParCleanOrgId { get; set; }

    public int? WmsmParGid { get; set; }

    public DateTime WmsmTsinsert { get; set; }

    public DateTime WmsmTsupdate { get; set; }

    public DateTime WmsmTimeFrom { get; set; }

    public DateTime? WmsmTimeTo { get; set; }

    public int WmsmChecksumKimball1 { get; set; }

    public int WmsmChecksumKimball2 { get; set; }

    public int WmsmUpdateSubTransformationId { get; set; }

    public int? WmsmUpdateTransformationId { get; set; }

    public int WmsmInsertSubTransformationId { get; set; }

    public int? WmsmInsertTransformationId { get; set; }

    public byte[] WmsmRowVersion { get; set; } = null!;

    /// <summary>
    /// Adres magazynu
    /// </summary>
    public string? WmsmAdres { get; set; }

    /// <summary>
    /// Flaga określająca czy magazyn jest obslugiwany przez WMS
    /// </summary>
    public string? WmsmCzyMagazynWms { get; set; }

    /// <summary>
    /// Czy WMS-owy magazyn jest magazynem wirtualnym
    /// </summary>
    public string? WmsmCzyWirtualny { get; set; }

    /// <summary>
    /// Czy jest to magazyn zbiorczy - czyli utworzony tylko w WMS
    /// </summary>
    public string? WmsmCzyZbiorczy { get; set; }

    /// <summary>
    /// Identyfikator magazynu WMS
    /// </summary>
    public int? WmsmMagazynWmsid { get; set; }

    /// <summary>
    /// Osoba odpoweidzialna za magazyn
    /// </summary>
    public string? WmsmOsobaOdpowiedzialna { get; set; }

    /// <summary>
    /// Symbol magazynu WMS
    /// </summary>
    public string? WmsmSymbol { get; set; }

    /// <summary>
    /// Typ magazynu WMS
    /// </summary>
    public string? WmsmTyp { get; set; }

    public virtual WymPracownik? WmsmOdpowiedzialny { get; set; }

    public virtual WymZrodloDanych WmsmZrodg { get; set; } = null!;

    public virtual ICollection<WymWmsstrukturaMagazynu> WymWmsstrukturaMagazynuWmssWmsmgs { get; set; } = new List<WymWmsstrukturaMagazynu>();

    public virtual ICollection<WymWmsstrukturaMagazynu> WymWmsstrukturaMagazynuWmssWmszmgs { get; set; } = new List<WymWmsstrukturaMagazynu>();
}
