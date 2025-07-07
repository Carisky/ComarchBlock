using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymRozpatrzenieReklamacji
{
    public int RekleId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? RekleRowId { get; set; }

    public byte[] RekleRowVersion { get; set; } = null!;

    public int? RekleInsertSubTransformationId { get; set; }

    public int RekleInsertTransformationId { get; set; }

    public int? RekleUpdateSubTransformationId { get; set; }

    public int RekleUpdateTransformationId { get; set; }

    public int RekleChecksumKimball2 { get; set; }

    public int RekleChecksumKimball1 { get; set; }

    public DateTime? RekleTimeTo { get; set; }

    public DateTime RekleTimeFrom { get; set; }

    public DateTime RekleTsupdate { get; set; }

    public DateTime RekleTsinsert { get; set; }

    public int? RekleParGid { get; set; }

    public string? RekleParCleanOrgId { get; set; }

    public string? RekleParDirtyOrgId { get; set; }

    public string? RekleOpis { get; set; }

    public string RekleNazwa { get; set; } = null!;

    public string RekleDirtyOrgId { get; set; } = null!;

    public string RekleOrgId { get; set; } = null!;

    public int RekleZrodgid { get; set; }
}
