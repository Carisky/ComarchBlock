using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymRejestr
{
    public int? RejRowId { get; set; }

    public int RejId { get; set; }

    public int RejZrodgid { get; set; }

    public string RejOrgId { get; set; } = null!;

    public string RejDirtyOrgId { get; set; } = null!;

    public string? RejParCleanOrgId { get; set; }

    public string? RejParDirtyOrgId { get; set; }

    public int? RejParGid { get; set; }

    public string? RejRejestr { get; set; }

    public string? RejTyp { get; set; }

    public DateTime RejTsinsert { get; set; }

    public DateTime RejTsupdate { get; set; }

    public int? RejUpdateTransformationId { get; set; }

    public int RejUpdateSubTransformationId { get; set; }

    public int? RejInsertTransformationId { get; set; }

    public int RejInsertSubTransformationId { get; set; }

    public DateTime RejTimeFrom { get; set; }

    public DateTime? RejTimeTo { get; set; }

    public int RejChecksumKimball1 { get; set; }

    public int RejChecksumKimball2 { get; set; }

    public byte[] RejRowVersion { get; set; } = null!;

    public string RejWalutaDirtyOrgId { get; set; } = null!;

    public int RejWalutaGid { get; set; }

    public string RejDokSerDirtyOrgId { get; set; } = null!;

    public int RejDokSerGid { get; set; }

    public string RejDokTypDirtyOrgId { get; set; } = null!;

    public int RejDokTypGid { get; set; }

    public int? BudgetMemberId { get; set; }
}
