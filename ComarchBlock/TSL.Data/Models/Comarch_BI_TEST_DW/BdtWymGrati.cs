using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymGrati
{
    public int GrtId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? GrtRowId { get; set; }

    public byte[] GrtRowVersion { get; set; } = null!;

    public int? GrtInsertSubTransformationId { get; set; }

    public int GrtInsertTransformationId { get; set; }

    public int? GrtUpdateSubTransformationId { get; set; }

    public int GrtUpdateTransformationId { get; set; }

    public int GrtChecksumKimball2 { get; set; }

    public int GrtChecksumKimball1 { get; set; }

    public DateTime? GrtTimeTo { get; set; }

    public DateTime GrtTimeFrom { get; set; }

    public DateTime GrtTsupdate { get; set; }

    public DateTime GrtTsinsert { get; set; }

    public int? GrtParGid { get; set; }

    public string? GrtParCleanOrgId { get; set; }

    public string? GrtParDirtyOrgId { get; set; }

    public string? GrtOpis { get; set; }

    public string GrtNazwa { get; set; } = null!;

    public string GrtDirtyOrgId { get; set; } = null!;

    public string GrtOrgId { get; set; } = null!;

    public int GrtZrodgid { get; set; }
}
