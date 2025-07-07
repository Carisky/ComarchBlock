using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymKontakt
{
    public int KtkId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? KtkRowId { get; set; }

    public byte[] KtkRowVersion { get; set; } = null!;

    public int? KtkInsertSubTransformationId { get; set; }

    public int KtkInsertTransformationId { get; set; }

    public int? KtkUpdateSubTransformationId { get; set; }

    public int KtkUpdateTransformationId { get; set; }

    public int KtkChecksumKimball2 { get; set; }

    public int KtkChecksumKimball1 { get; set; }

    public DateTime? KtkTimeTo { get; set; }

    public DateTime KtkTimeFrom { get; set; }

    public DateTime KtkTsupdate { get; set; }

    public DateTime KtkTsinsert { get; set; }

    public int? KtkParGid { get; set; }

    public string? KtkParCleanOrgId { get; set; }

    public string? KtkParDirtyOrgId { get; set; }

    public string? KtkOpis { get; set; }

    public string KtkNazwa { get; set; } = null!;

    public string KtkDirtyOrgId { get; set; } = null!;

    public string KtkCleanOrgId { get; set; } = null!;

    public int KtkZrodid { get; set; }
}
