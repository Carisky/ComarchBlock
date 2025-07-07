using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymTypZamowienium
{
    public int TzamId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? TzamRowId { get; set; }

    public byte[] TzamRowVersion { get; set; } = null!;

    public int? TzamInsertSubTransformationId { get; set; }

    public int TzamInsertTransformationId { get; set; }

    public int? TzamUpdateSubTransformationId { get; set; }

    public int TzamUpdateTransformationId { get; set; }

    public int TzamChecksumKimball2 { get; set; }

    public int TzamChecksumKimball1 { get; set; }

    public DateTime? TzamTimeTo { get; set; }

    public DateTime TzamTimeFrom { get; set; }

    public DateTime TzamTsupdate { get; set; }

    public DateTime TzamTsinsert { get; set; }

    public int? TzamParGid { get; set; }

    public string? TzamParCleanOrgId { get; set; }

    public string? TzamParDirtyOrgId { get; set; }

    public string? TzamOpis { get; set; }

    public string TzamNazwa { get; set; } = null!;

    public string TzamDirtyOrgId { get; set; } = null!;

    public string TzamOrgId { get; set; } = null!;

    public int TzamZrodgid { get; set; }
}
