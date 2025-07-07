using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymPrecyzjaMiary
{
    public int PrmRowId { get; set; }

    public int PrmId { get; set; }

    public int PrmZrodgid { get; set; }

    public string PrmOrgId { get; set; } = null!;

    public string PrmDirtyOrgId { get; set; } = null!;

    public string PrmNazwa { get; set; } = null!;

    public string? PrmOpis { get; set; }

    public string? PrmParDirtyOrgId { get; set; }

    public string? PrmParCleanOrgId { get; set; }

    public int? PrmParGid { get; set; }

    public DateTime PrmTsinsert { get; set; }

    public DateTime PrmTsupdate { get; set; }

    public DateTime PrmTimeFrom { get; set; }

    public DateTime? PrmTimeTo { get; set; }

    public int PrmChecksumKimball1 { get; set; }

    public int PrmChecksumKimball2 { get; set; }

    public int PrmUpdateSubTransformationId { get; set; }

    public int? PrmUpdateTransformationId { get; set; }

    public int PrmInsertSubTransformationId { get; set; }

    public int? PrmInsertTransformationId { get; set; }

    public byte[] PrmRowVersion { get; set; } = null!;
}
