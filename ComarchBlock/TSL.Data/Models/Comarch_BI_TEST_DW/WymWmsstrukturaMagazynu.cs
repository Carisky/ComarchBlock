using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

/// <summary>
/// Struktura magazynu WMS-owego
/// </summary>
public partial class WymWmsstrukturaMagazynu
{
    /// <summary>
    /// Relation to dimension WMSMagazyn. Wskazania na magazyn WMS
    /// </summary>
    public int WmssWmsmgid { get; set; }

    /// <summary>
    /// Relation to dimension WMSMagazyn. Wskazanie na magazyn zbiorczy WMS
    /// </summary>
    public int WmssWmszmgid { get; set; }

    public int WmssRowId { get; set; }

    public int WmssId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int WmssZrodgid { get; set; }

    public string WmssOrgId { get; set; } = null!;

    public string WmssDirtyOrgId { get; set; } = null!;

    public string? WmssNazwa { get; set; }

    public string? WmssOpis { get; set; }

    public string? WmssParDirtyOrgId { get; set; }

    public string? WmssParCleanOrgId { get; set; }

    public int? WmssParGid { get; set; }

    public DateTime WmssTsinsert { get; set; }

    public DateTime WmssTsupdate { get; set; }

    public DateTime WmssTimeFrom { get; set; }

    public DateTime? WmssTimeTo { get; set; }

    public int WmssChecksumKimball1 { get; set; }

    public int WmssChecksumKimball2 { get; set; }

    public int WmssUpdateSubTransformationId { get; set; }

    public int? WmssUpdateTransformationId { get; set; }

    public int WmssInsertSubTransformationId { get; set; }

    public int? WmssInsertTransformationId { get; set; }

    public byte[] WmssRowVersion { get; set; } = null!;

    /// <summary>
    /// Kod elementu struktury magazynu WMS
    /// </summary>
    public string WmssKod { get; set; } = null!;

    /// <summary>
    /// Pełny kod elementu struktury magazynu WMS
    /// </summary>
    public string? WmssPelnyKod { get; set; }

    public virtual ICollection<FktWm> FktWmWmsfWmssdgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfWmssgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfWmssnadGs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfWmsssgs { get; set; } = new List<FktWm>();

    public virtual WymWmsmagazyn WmssWmsmg { get; set; } = null!;

    public virtual WymWmsmagazyn WmssWmszmg { get; set; } = null!;

    public virtual WymZrodloDanych WmssZrodg { get; set; } = null!;
}
