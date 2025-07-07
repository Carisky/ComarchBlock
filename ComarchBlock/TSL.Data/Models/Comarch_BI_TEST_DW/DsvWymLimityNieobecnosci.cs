using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymLimityNieobecnosci
{
    public int LimRowId { get; set; }

    public int LimId { get; set; }

    public int LimZrodgid { get; set; }

    public string LimOrgId { get; set; } = null!;

    public string LimDirtyOrgId { get; set; } = null!;

    public string LimNazwa { get; set; } = null!;

    public string? LimOpis { get; set; }

    public string? LimParDirtyOrgId { get; set; }

    public string? LimParCleanOrgId { get; set; }

    public int? LimParGid { get; set; }

    public DateTime LimTsinsert { get; set; }

    public DateTime LimTsupdate { get; set; }

    public DateTime LimTimeFrom { get; set; }

    public DateTime? LimTimeTo { get; set; }

    public int LimChecksumKimball1 { get; set; }

    public int LimChecksumKimball2 { get; set; }

    public int LimUpdateSubTransformationId { get; set; }

    public int? LimUpdateTransformationId { get; set; }

    public int LimInsertSubTransformationId { get; set; }

    public int? LimInsertTransformationId { get; set; }

    public byte[] LimRowVersion { get; set; } = null!;

    public string? LimTypLimitu { get; set; }
}
