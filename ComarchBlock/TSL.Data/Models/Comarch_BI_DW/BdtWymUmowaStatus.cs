using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymUmowaStatus
{
    public int UmsId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? UmsRowId { get; set; }

    public string? UmsRodzaj { get; set; }

    public byte[] UmsRowVersion { get; set; } = null!;

    public int? UmsInsertTransformationId { get; set; }

    public int UmsInsertSubTransformationId { get; set; }

    public int? UmsUpdateTransformationId { get; set; }

    public int? UmsUpdateSubTransformationId { get; set; }

    public int UmsChecksumKimball2 { get; set; }

    public int UmsChecksumKimball1 { get; set; }

    public DateTime? UmsTimeTo { get; set; }

    public DateTime UmsTimeFrom { get; set; }

    public DateTime UmsTsupdate { get; set; }

    public DateTime UmsTsinsert { get; set; }

    public int? UmsParGid { get; set; }

    public string? UmsParCleanOrgId { get; set; }

    public string? UmsParDirtyOrgId { get; set; }

    public string? UmsOpis { get; set; }

    public string UmsNazwa { get; set; } = null!;

    public string UmsDirtyOrgId { get; set; } = null!;

    public string UmsOrgId { get; set; } = null!;

    public int UmsZrodgid { get; set; }
}
