using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymPrzestojTyp
{
    public int? TprzRowId { get; set; }

    public int TprzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int TprzZrodgid { get; set; }

    public string TprzOrgId { get; set; } = null!;

    public string TprzDirtyOrgId { get; set; } = null!;

    public string TprzNazwa { get; set; } = null!;

    public string? TprzOpis { get; set; }

    public string? TprzParDirtyOrgId { get; set; }

    public string? TprzParCleanOrgId { get; set; }

    public int? TprzParGid { get; set; }

    public DateTime TprzTsinsert { get; set; }

    public DateTime TprzTsupdate { get; set; }

    public DateTime TprzTimeFrom { get; set; }

    public DateTime? TprzTimeTo { get; set; }

    public int TprzChecksumKimball1 { get; set; }

    public int TprzChecksumKimball2 { get; set; }

    public int TprzUpdateSubTransformationId { get; set; }

    public int? TprzUpdateTransformationId { get; set; }

    public int TprzInsertSubTransformationId { get; set; }

    public int? TprzInsertTransformationId { get; set; }

    public byte[] TprzRowVersion { get; set; } = null!;
}
