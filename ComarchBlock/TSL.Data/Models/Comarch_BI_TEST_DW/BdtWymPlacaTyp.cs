using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymPlacaTyp
{
    public int PltId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PltRowId { get; set; }

    public byte[] PltRowVersion { get; set; } = null!;

    public int? PltInsertTransformationId { get; set; }

    public int PltInsertSubTransformationId { get; set; }

    public int? PltUpdateTransformationId { get; set; }

    public int PltUpdateSubTransformationId { get; set; }

    public int PltChecksumKimball2 { get; set; }

    public int PltChecksumKimball1 { get; set; }

    public DateTime? PltTimeTo { get; set; }

    public DateTime PltTimeFrom { get; set; }

    public DateTime PltTsupdate { get; set; }

    public DateTime PltTsinsert { get; set; }

    public int? PltParGid { get; set; }

    public string? PltParCleanOrgId { get; set; }

    public string? PltParDirtyOrgId { get; set; }

    public string? PltOpis { get; set; }

    public string PltNazwa { get; set; } = null!;

    public string PltDirtyOrgId { get; set; } = null!;

    public string PltOrgId { get; set; } = null!;

    public int PltZrodgid { get; set; }
}
