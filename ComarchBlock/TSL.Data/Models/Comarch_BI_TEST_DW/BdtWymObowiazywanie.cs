using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymObowiazywanie
{
    public int ObzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ObzRowId { get; set; }

    public string? ObzTypOrgId { get; set; }

    public int? ObzDo { get; set; }

    public int? ObzOd { get; set; }

    public byte[] ObzRowVersion { get; set; } = null!;

    public int? ObzInsertTransformationId { get; set; }

    public int? ObzInsertSubTransformationId { get; set; }

    public int? ObzUpdateTransformationId { get; set; }

    public int? ObzUpdateSubTransformationId { get; set; }

    public int ObzChecksumKimball2 { get; set; }

    public int ObzChecksumKimball1 { get; set; }

    public DateTime? ObzTimeTo { get; set; }

    public DateTime ObzTimeFrom { get; set; }

    public DateTime ObzTsupdate { get; set; }

    public DateTime ObzTsinsert { get; set; }

    public int? ObzParGid { get; set; }

    public string? ObzParCleanOrgId { get; set; }

    public string? ObzParDirtyOrgId { get; set; }

    public string? ObzOpis { get; set; }

    public string? ObzNazwa { get; set; }

    public string ObzDirtyOrgId { get; set; } = null!;

    public string ObzOrgId { get; set; } = null!;

    public int ObzZrodgid { get; set; }
}
