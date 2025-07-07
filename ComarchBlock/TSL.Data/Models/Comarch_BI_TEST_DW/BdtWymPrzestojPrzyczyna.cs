using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymPrzestojPrzyczyna
{
    public int? PrzyprzRowId { get; set; }

    public int PrzyprzId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int PrzyprzZrodgid { get; set; }

    public string PrzyprzOrgId { get; set; } = null!;

    public string PrzyprzDirtyOrgId { get; set; } = null!;

    public string PrzyprzNazwa { get; set; } = null!;

    public string? PrzyprzOpis { get; set; }

    public string? PrzyprzParDirtyOrgId { get; set; }

    public string? PrzyprzParCleanOrgId { get; set; }

    public int? PrzyprzParGid { get; set; }

    public DateTime PrzyprzTsinsert { get; set; }

    public DateTime PrzyprzTsupdate { get; set; }

    public DateTime PrzyprzTimeFrom { get; set; }

    public DateTime? PrzyprzTimeTo { get; set; }

    public int PrzyprzChecksumKimball1 { get; set; }

    public int PrzyprzChecksumKimball2 { get; set; }

    public int PrzyprzUpdateSubTransformationId { get; set; }

    public int? PrzyprzUpdateTransformationId { get; set; }

    public int PrzyprzInsertSubTransformationId { get; set; }

    public int? PrzyprzInsertTransformationId { get; set; }

    public byte[] PrzyprzRowVersion { get; set; } = null!;
}
