using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymJednostkaCzasu
{
    public int JczChecksumKimball1 { get; set; }

    public int JczChecksumKimball2 { get; set; }

    public string JczDirtyOrgId { get; set; } = null!;

    public int JczId { get; set; }

    public int? JczInsertSubTransformationId { get; set; }

    public int JczInsertTransformationId { get; set; }

    public string JczNazwa { get; set; } = null!;

    public string JczOpis { get; set; } = null!;

    public string JczOrgId { get; set; } = null!;

    public string? JczParCleanOrgId { get; set; }

    public string? JczParDirtyOrgId { get; set; }

    public int? JczParGid { get; set; }

    public int? JczRowId { get; set; }

    public byte[] JczRowVersion { get; set; } = null!;

    public DateTime JczTimeFrom { get; set; }

    public DateTime? JczTimeTo { get; set; }

    public DateTime JczTsinsert { get; set; }

    public DateTime JczTsupdate { get; set; }

    public int? JczUpdateSubTransformationId { get; set; }

    public int JczUpdateTransformationId { get; set; }

    public int JczZrodgid { get; set; }
}
