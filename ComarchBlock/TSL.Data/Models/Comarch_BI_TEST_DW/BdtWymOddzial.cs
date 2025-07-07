using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymOddzial
{
    public int OddId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? OddRowId { get; set; }

    public string OddOpis { get; set; } = null!;

    public string OddNazwa { get; set; } = null!;

    public int OddZrodgid { get; set; }

    public int OddUpdateTransformationId { get; set; }

    public int? OddUpdateSubTransformationId { get; set; }

    public DateTime OddTsupdate { get; set; }

    public DateTime OddTsinsert { get; set; }

    public DateTime? OddTimeTo { get; set; }

    public DateTime OddTimeFrom { get; set; }

    public byte[] OddRowVersion { get; set; } = null!;

    public int? OddParGid { get; set; }

    public string? OddParDirtyOrgId { get; set; }

    public string? OddParCleanOrgId { get; set; }

    public string OddOrgId { get; set; } = null!;

    public int OddInsertTransformationId { get; set; }

    public int? OddInsertSubTransformationId { get; set; }

    public string OddDirtyOrgId { get; set; } = null!;

    public int OddChecksumKimball2 { get; set; }

    public int OddChecksumKimball1 { get; set; }
}
