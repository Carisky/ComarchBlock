using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymJednostkaCzasu
{
    public int JczId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? JczRowId { get; set; }

    public byte[] JczRowVersion { get; set; } = null!;

    public int? JczInsertSubTransformationId { get; set; }

    public int JczInsertTransformationId { get; set; }

    public int? JczUpdateSubTransformationId { get; set; }

    public int JczUpdateTransformationId { get; set; }

    public int JczChecksumKimball2 { get; set; }

    public int JczChecksumKimball1 { get; set; }

    public DateTime? JczTimeTo { get; set; }

    public DateTime JczTimeFrom { get; set; }

    public DateTime JczTsupdate { get; set; }

    public DateTime JczTsinsert { get; set; }

    public int? JczParGid { get; set; }

    public string? JczParCleanOrgId { get; set; }

    public string? JczParDirtyOrgId { get; set; }

    public string JczOpis { get; set; } = null!;

    public string JczNazwa { get; set; } = null!;

    public string JczDirtyOrgId { get; set; } = null!;

    public string JczOrgId { get; set; } = null!;

    public int JczZrodgid { get; set; }
}
