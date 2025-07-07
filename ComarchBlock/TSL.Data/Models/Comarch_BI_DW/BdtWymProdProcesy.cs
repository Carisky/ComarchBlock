using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymProdProcesy
{
    public int PpcId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PpcRowId { get; set; }

    public int PpcZrodgid { get; set; }

    public string PpcOrgId { get; set; } = null!;

    public string PpcDirtyOrgId { get; set; } = null!;

    public string PpcNazwa { get; set; } = null!;

    public string? PpcOpis { get; set; }

    public string? PpcParDirtyOrgId { get; set; }

    public string? PpcParCleanOrgId { get; set; }

    public int? PpcParGid { get; set; }

    public DateTime PpcTsinsert { get; set; }

    public DateTime PpcTsupdate { get; set; }

    public DateTime PpcTimeFrom { get; set; }

    public DateTime? PpcTimeTo { get; set; }

    public int PpcChecksumKimball1 { get; set; }

    public int PpcChecksumKimball2 { get; set; }

    public int PpcUpdateSubTransformationId { get; set; }

    public int? PpcUpdateTransformationId { get; set; }

    public int PpcInsertSubTransformationId { get; set; }

    public int? PpcInsertTransformationId { get; set; }

    public byte[] PpcRowVersion { get; set; } = null!;
}
