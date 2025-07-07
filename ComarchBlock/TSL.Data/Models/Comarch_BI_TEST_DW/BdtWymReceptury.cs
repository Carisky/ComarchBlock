using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymReceptury
{
    public int RecProdGid { get; set; }

    public int RecRowId { get; set; }

    public int RecId { get; set; }

    public int RecZrodgid { get; set; }

    public string RecOrgId { get; set; } = null!;

    public string RecDirtyOrgId { get; set; } = null!;

    public string RecNazwa { get; set; } = null!;

    public string? RecOpis { get; set; }

    public string? RecParDirtyOrgId { get; set; }

    public string? RecParCleanOrgId { get; set; }

    public int? RecParGid { get; set; }

    public DateTime RecTsinsert { get; set; }

    public DateTime RecTsupdate { get; set; }

    public DateTime RecTimeFrom { get; set; }

    public DateTime? RecTimeTo { get; set; }

    public int RecChecksumKimball1 { get; set; }

    public int RecChecksumKimball2 { get; set; }

    public int RecUpdateSubTransformationId { get; set; }

    public int? RecUpdateTransformationId { get; set; }

    public int RecInsertSubTransformationId { get; set; }

    public int? RecInsertTransformationId { get; set; }

    public byte[] RecRowVersion { get; set; } = null!;

    public int? RecDomyslna { get; set; }

    public string? RecJmProduktu { get; set; }

    public string? RecOrgAtrId { get; set; }

    public string? RecSymbol { get; set; }

    public int? RecTyp { get; set; }

    public int? BudgetMemberId { get; set; }
}
