using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymOddzial
{
    public int OddChecksumKimball1 { get; set; }

    public int OddChecksumKimball2 { get; set; }

    public string OddDirtyOrgId { get; set; } = null!;

    public int OddId { get; set; }

    public int? OddInsertSubTransformationId { get; set; }

    public int OddInsertTransformationId { get; set; }

    public string OddNazwa { get; set; } = null!;

    public string OddOpis { get; set; } = null!;

    public string OddOrgId { get; set; } = null!;

    public string? OddParCleanOrgId { get; set; }

    public string? OddParDirtyOrgId { get; set; }

    public int? OddParGid { get; set; }

    public int? OddRowId { get; set; }

    public byte[] OddRowVersion { get; set; } = null!;

    public DateTime OddTimeFrom { get; set; }

    public DateTime? OddTimeTo { get; set; }

    public DateTime OddTsinsert { get; set; }

    public DateTime OddTsupdate { get; set; }

    public int? OddUpdateSubTransformationId { get; set; }

    public int OddUpdateTransformationId { get; set; }

    public int OddZrodgid { get; set; }
}
