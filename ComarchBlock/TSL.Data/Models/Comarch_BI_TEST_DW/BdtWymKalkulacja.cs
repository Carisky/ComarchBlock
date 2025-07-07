using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymKalkulacja
{
    public int? KlkRowId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int KlkId { get; set; }

    public int KlkZrodgid { get; set; }

    public string KlkOrgId { get; set; } = null!;

    public string KlkDirtyOrgId { get; set; } = null!;

    public string KlkNazwa { get; set; } = null!;

    public string? KlkOpis { get; set; }

    public string? KlkParDirtyOrgId { get; set; }

    public string? KlkParCleanOrgId { get; set; }

    public int? KlkParGid { get; set; }

    public DateTime KlkTsinsert { get; set; }

    public DateTime KlkTsupdate { get; set; }

    public DateTime KlkTimeFrom { get; set; }

    public DateTime? KlkTimeTo { get; set; }

    public int KlkChecksumKimball1 { get; set; }

    public int KlkChecksumKimball2 { get; set; }

    public int KlkUpdateSubTransformationId { get; set; }

    public int? KlkUpdateTransformationId { get; set; }

    public int KlkInsertSubTransformationId { get; set; }

    public int? KlkInsertTransformationId { get; set; }

    public byte[] KlkRowVersion { get; set; } = null!;

    public string? KlkPodstawaSymulacjiMaterialu { get; set; }

    public string? KlkPodstawaSymulacjiGniazda { get; set; }
}
