using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymEkspozycjeTowarow
{
    public int EktId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? EktRowId { get; set; }

    public string? EktSatus { get; set; }

    public bool? EktAktywny { get; set; }

    public string? EktWartosc { get; set; }

    public byte[] EktRowVersion { get; set; } = null!;

    public int? EktInsertSubTransformationId { get; set; }

    public int EktInsertTransformationId { get; set; }

    public int? EktUpdateSubTransformationId { get; set; }

    public int EktUpdateTransformationId { get; set; }

    public int EktChecksumKimball2 { get; set; }

    public int EktChecksumKimball1 { get; set; }

    public DateTime? EktTimeTo { get; set; }

    public DateTime EktTimeFrom { get; set; }

    public DateTime EktTsupdate { get; set; }

    public DateTime EktTsinsert { get; set; }

    public int? EktParGid { get; set; }

    public string? EktParCleanOrgId { get; set; }

    public string? EktParDirtyOrgId { get; set; }

    public string? EktOpis { get; set; }

    public string EktNazwa { get; set; } = null!;

    public string EktDirtyOrgId { get; set; } = null!;

    public string EktOrgId { get; set; } = null!;

    public int EktZrodgid { get; set; }
}
