using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtWymLokataStatus
{
    public int LokStId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? LokStRowId { get; set; }

    public byte[] LokStRowVersion { get; set; } = null!;

    public int? LokStInsertSubTransformationId { get; set; }

    public int LokStInsertTransformationId { get; set; }

    public int? LokStUpdateSubTransformationId { get; set; }

    public int LokStUpdateTransformationId { get; set; }

    public int LokStChecksumKimball2 { get; set; }

    public int LokStChecksumKimball1 { get; set; }

    public DateTime? LokStTimeTo { get; set; }

    public DateTime LokStTimeFrom { get; set; }

    public DateTime LokStTsupdate { get; set; }

    public DateTime LokStTsinsert { get; set; }

    public int? LokStParGid { get; set; }

    public string? LokStParCleanOrgId { get; set; }

    public string? LokStParDirtyOrgId { get; set; }

    public string? LokStOpis { get; set; }

    public string LokStNazwa { get; set; } = null!;

    public string LokStDirtyOrgId { get; set; } = null!;

    public string LokStOrgId { get; set; } = null!;

    public int LokStZrodgid { get; set; }
}
