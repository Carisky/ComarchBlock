using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymUmowaElement
{
    public int UmeId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? UmeRowId { get; set; }

    public string? UmeWlasciwoscW { get; set; }

    public string? UmeWlasciwosc { get; set; }

    public string? UmeKod { get; set; }

    public byte[] UmeRowVersion { get; set; } = null!;

    public int? UmeInsertTransformationId { get; set; }

    public int? UmeInsertSubTransformationId { get; set; }

    public int? UmeUpdateTransformationId { get; set; }

    public int? UmeUpdateSubTransformationId { get; set; }

    public int UmeChecksumKimball2 { get; set; }

    public int UmeChecksumKimball1 { get; set; }

    public DateTime? UmeTimeTo { get; set; }

    public DateTime UmeTimeFrom { get; set; }

    public DateTime UmeTsupdate { get; set; }

    public DateTime UmeTsinsert { get; set; }

    public int? UmeParGid { get; set; }

    public string? UmeParCleanOrgId { get; set; }

    public string? UmeParDirtyOrgId { get; set; }

    public string? UmeOpis { get; set; }

    public string UmeNazwa { get; set; } = null!;

    public string UmeDirtyOrgId { get; set; } = null!;

    public string UmeOrgId { get; set; } = null!;

    public int UmeZrodgid { get; set; }
}
