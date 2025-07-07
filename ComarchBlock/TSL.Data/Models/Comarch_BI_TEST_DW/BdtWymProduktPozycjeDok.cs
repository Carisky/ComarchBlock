using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymProduktPozycjeDok
{
    public int PpdId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PpdRowId { get; set; }

    public string? PpdZlom { get; set; }

    public string? PpdGratis { get; set; }

    public byte[] PpdRowVersion { get; set; } = null!;

    public int? PpdInsertSubTransformationId { get; set; }

    public int PpdInsertTransformationId { get; set; }

    public int? PpdUpdateSubTransformationId { get; set; }

    public int PpdUpdateTransformationId { get; set; }

    public int PpdChecksumKimball2 { get; set; }

    public int PpdChecksumKimball1 { get; set; }

    public DateTime? PpdTimeTo { get; set; }

    public DateTime PpdTimeFrom { get; set; }

    public DateTime PpdTsupdate { get; set; }

    public DateTime PpdTsinsert { get; set; }

    public int? PpdParGid { get; set; }

    public string? PpdParCleanOrgId { get; set; }

    public string? PpdParDirtyOrgId { get; set; }

    public string? PpdOpis { get; set; }

    public string? PpdNazwa { get; set; }

    public string PpdDirtyOrgId { get; set; } = null!;

    public string PpdCleanOrgId { get; set; } = null!;

    public int PpdZrodgid { get; set; }

    public string? PpdPrzyczynaKorekty { get; set; }
}
