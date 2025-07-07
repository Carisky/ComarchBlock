using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymTechnologium
{
    public int TchId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? TchRowId { get; set; }

    public string? TchKod { get; set; }

    public string? TchOrgAtrId { get; set; }

    public string? TchOpis { get; set; }

    public string TchNazwa { get; set; } = null!;

    public int TchZrodgid { get; set; }

    public int TchUpdateTransformationId { get; set; }

    public int? TchUpdateSubTransformationId { get; set; }

    public DateTime TchTsupdate { get; set; }

    public DateTime TchTsinsert { get; set; }

    public DateTime? TchTimeTo { get; set; }

    public DateTime TchTimeFrom { get; set; }

    public byte[] TchRowVersion { get; set; } = null!;

    public int? TchParGid { get; set; }

    public string? TchParDirtyOrgId { get; set; }

    public string? TchParCleanOrgId { get; set; }

    public string TchOrgId { get; set; } = null!;

    public int TchInsertTransformationId { get; set; }

    public int? TchInsertSubTransformationId { get; set; }

    public string TchDirtyOrgId { get; set; } = null!;

    public int TchChecksumKimball2 { get; set; }

    public int TchChecksumKimball1 { get; set; }
}
