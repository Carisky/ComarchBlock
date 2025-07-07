using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymKategoriaAbcxyz
{
    public int AbcId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? AbcRowId { get; set; }

    public string? AbcTowarRodzaj { get; set; }

    public byte[] AbcRowVersion { get; set; } = null!;

    public int? AbcInsertSubTransformationId { get; set; }

    public int AbcInsertTransformationId { get; set; }

    public int? AbcUpdateSubTransformationId { get; set; }

    public int AbcUpdateTransformationId { get; set; }

    public int AbcChecksumKimball2 { get; set; }

    public int AbcChecksumKimball1 { get; set; }

    public DateTime? AbcTimeTo { get; set; }

    public DateTime AbcTimeFrom { get; set; }

    public DateTime AbcTsupdate { get; set; }

    public DateTime AbcTsinsert { get; set; }

    public int? AbcParGid { get; set; }

    public string? AbcParCleanOrgId { get; set; }

    public string? AbcParDirtyOrgId { get; set; }

    public string? AbcOpis { get; set; }

    public string AbcNazwa { get; set; } = null!;

    public string AbcDirtyOrgId { get; set; } = null!;

    public string AbcOrgId { get; set; } = null!;

    public int AbcZrodgid { get; set; }
}
