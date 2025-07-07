using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymPomocniczy
{
    public int PomocId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PomocRowId { get; set; }

    public int? PomocTyp { get; set; }

    public string? PomocOrgId1 { get; set; }

    public string? PomocOpis { get; set; }

    public string PomocNazwa { get; set; } = null!;

    public int PomocZrodgid { get; set; }

    public int PomocUpdateTransformationId { get; set; }

    public int? PomocUpdateSubTransformationId { get; set; }

    public DateTime PomocTsupdate { get; set; }

    public DateTime PomocTsinsert { get; set; }

    public DateTime? PomocTimeTo { get; set; }

    public DateTime PomocTimeFrom { get; set; }

    public byte[] PomocRowVersion { get; set; } = null!;

    public int? PomocParGid { get; set; }

    public string? PomocParDirtyOrgId { get; set; }

    public string? PomocParCleanOrgId { get; set; }

    public string PomocOrgId { get; set; } = null!;

    public int PomocInsertTransformationId { get; set; }

    public int? PomocInsertSubTransformationId { get; set; }

    public string PomocDirtyOrgId { get; set; } = null!;

    public int PomocChecksumKimball2 { get; set; }

    public int PomocChecksumKimball1 { get; set; }
}
