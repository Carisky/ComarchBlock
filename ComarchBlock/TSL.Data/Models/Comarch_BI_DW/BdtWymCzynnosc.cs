using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymCzynnosc
{
    public int CznId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? CznRowId { get; set; }

    public string? CznOpis { get; set; }

    public string CznNazwa { get; set; } = null!;

    public int CznZrodgid { get; set; }

    public int CznUpdateTransformationId { get; set; }

    public int? CznUpdateSubTransformationId { get; set; }

    public DateTime CznTsupdate { get; set; }

    public DateTime CznTsinsert { get; set; }

    public DateTime? CznTimeTo { get; set; }

    public DateTime CznTimeFrom { get; set; }

    public byte[] CznRowVersion { get; set; } = null!;

    public int? CznParGid { get; set; }

    public string? CznParDirtyOrgId { get; set; }

    public string? CznParCleanOrgId { get; set; }

    public string CznOrgId { get; set; } = null!;

    public int CznInsertTransformationId { get; set; }

    public int? CznInsertSubTransformationId { get; set; }

    public string CznDirtyOrgId { get; set; } = null!;

    public int CznChecksumKimball2 { get; set; }

    public int CznChecksumKimball1 { get; set; }

    public string? CznKod { get; set; }
}
