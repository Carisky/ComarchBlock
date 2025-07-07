using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymLudnoscGrupyGu
{
    public int LugChecksumKimball1 { get; set; }

    public int LugChecksumKimball2 { get; set; }

    public string LugDirtyOrgId { get; set; } = null!;

    public int LugId { get; set; }

    public int? LugInsertSubTransformationId { get; set; }

    public int LugInsertTransformationId { get; set; }

    public string LugNazwa { get; set; } = null!;

    public string? LugOpis { get; set; }

    public string LugOrgId { get; set; } = null!;

    public string? LugParDirtyOrgId { get; set; }

    public int? LugParGid { get; set; }

    public string? LugParOrgId { get; set; }

    public int? LugRowId { get; set; }

    public byte[] LugRowVersion { get; set; } = null!;

    public DateTime LugTimeFrom { get; set; }

    public DateTime? LugTimeTo { get; set; }

    public DateTime LugTsinsert { get; set; }

    public DateTime LugTsupdate { get; set; }

    public int? LugUpdateSubTransformationId { get; set; }

    public int LugUpdateTransformationId { get; set; }

    public int LugZrodgid { get; set; }
}
