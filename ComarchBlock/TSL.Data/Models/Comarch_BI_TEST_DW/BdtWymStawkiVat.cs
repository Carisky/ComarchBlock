using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymStawkiVat
{
    public int SvatId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? SvatRowId { get; set; }

    public string? SvatStawka { get; set; }

    public string? SvatGrupa { get; set; }

    public byte[] SvatRowVersion { get; set; } = null!;

    public int? SvatInsertTransformationId { get; set; }

    public int? SvatInsertSubTransformationId { get; set; }

    public int? SvatUpdateTransformationId { get; set; }

    public int? SvatUpdateSubTransformationId { get; set; }

    public int SvatChecksumKimball2 { get; set; }

    public int SvatChecksumKimball1 { get; set; }

    public DateTime? SvatTimeTo { get; set; }

    public DateTime SvatTimeFrom { get; set; }

    public DateTime SvatTsupdate { get; set; }

    public DateTime SvatTsinsert { get; set; }

    public int? SvatParGid { get; set; }

    public string? SvatParCleanOrgId { get; set; }

    public string? SvatParDirtyOrgId { get; set; }

    public string? SvatOpis { get; set; }

    public string SvatNazwa { get; set; } = null!;

    public string SvatDirtyOrgId { get; set; } = null!;

    public string SvatOrgId { get; set; } = null!;

    public int SvatZrodgid { get; set; }
}
