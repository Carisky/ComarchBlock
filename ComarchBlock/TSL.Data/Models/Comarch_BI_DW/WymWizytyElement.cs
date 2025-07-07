using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymWizytyElement
{
    public int WelRowId { get; set; }

    public int WelId { get; set; }

    public int WelZrodgid { get; set; }

    public string WelOrgId { get; set; } = null!;

    public string WelDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Nazwa elementu wizyty handlowej
    /// </summary>
    public string WelNazwa { get; set; } = null!;

    /// <summary>
    /// Opis elementu wizyty handlowej
    /// </summary>
    public string? WelOpis { get; set; }

    public string? WelParDirtyOrgId { get; set; }

    public string? WelParCleanOrgId { get; set; }

    public int? WelParGid { get; set; }

    public DateTime WelTsinsert { get; set; }

    public DateTime WelTsupdate { get; set; }

    public DateTime WelTimeFrom { get; set; }

    public DateTime? WelTimeTo { get; set; }

    public int WelChecksumKimball1 { get; set; }

    public int WelChecksumKimball2 { get; set; }

    public int WelUpdateTransformationId { get; set; }

    public int? WelUpdateSubTransformationId { get; set; }

    public int WelInsertTransformationId { get; set; }

    public int? WelInsertSubTransformationId { get; set; }

    public byte[] WelRowVersion { get; set; } = null!;

    /// <summary>
    /// Kod elementu wizyty handlowej
    /// </summary>
    public string? WelKod { get; set; }

    /// <summary>
    /// Status wykonania elementu wizyty handlowej
    /// </summary>
    public string? WelStatus { get; set; }

    /// <summary>
    /// Powód niewykonania elementu wizyty handlowej
    /// </summary>
    public string? WelPowodNiewykonania { get; set; }

    public virtual WymZrodloDanych WelZrodg { get; set; } = null!;
}
