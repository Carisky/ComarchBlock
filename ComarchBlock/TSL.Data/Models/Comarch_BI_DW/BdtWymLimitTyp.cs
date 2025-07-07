using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Wymiar przechowuje informację, czy limit był wartościowy czy ilościowy.
/// </summary>
public partial class BdtWymLimitTyp
{
    public int LtRowId { get; set; }

    public int LtId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int LtZrodgid { get; set; }

    public string LtOrgId { get; set; } = null!;

    public string LtDirtyOrgId { get; set; } = null!;

    public string LtNazwa { get; set; } = null!;

    public string? LtOpis { get; set; }

    public string? LtParDirtyOrgId { get; set; }

    public string? LtParCleanOrgId { get; set; }

    public int? LtParGid { get; set; }

    public DateTime LtTsinsert { get; set; }

    public DateTime LtTsupdate { get; set; }

    public DateTime LtTimeFrom { get; set; }

    public DateTime? LtTimeTo { get; set; }

    public int LtChecksumKimball1 { get; set; }

    public int LtChecksumKimball2 { get; set; }

    public int? LtUpdateSubTransformationId { get; set; }

    public int? LtUpdateTransformationId { get; set; }

    public int? LtInsertSubTransformationId { get; set; }

    public int? LtInsertTransformationId { get; set; }

    public byte[] LtRowVersion { get; set; } = null!;

    public int? BudgetMemberId { get; set; }

    public virtual WymZrodloDanych LtZrodg { get; set; } = null!;
}
