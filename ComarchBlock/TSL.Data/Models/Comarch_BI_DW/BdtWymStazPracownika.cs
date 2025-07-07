using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymStazPracownika
{
    public int PrstId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? PrstRowId { get; set; }

    public string? PrstTypOrgId { get; set; }

    public int? PrstDo { get; set; }

    public int? PrstOd { get; set; }

    public byte[] PrstRowVersion { get; set; } = null!;

    public int? PrstInsertTransformationId { get; set; }

    public int? PrstInsertSubTransformationId { get; set; }

    public int? PrstUpdateTransformationId { get; set; }

    public int? PrstUpdateSubTransformationId { get; set; }

    public int PrstChecksumKimball2 { get; set; }

    public int PrstChecksumKimball1 { get; set; }

    public DateTime? PrstTimeTo { get; set; }

    public DateTime PrstTimeFrom { get; set; }

    public DateTime PrstTsupdate { get; set; }

    public DateTime PrstTsinsert { get; set; }

    public int? PrstParGid { get; set; }

    public string? PrstParCleanOrgId { get; set; }

    public string? PrstParDirtyOrgId { get; set; }

    public string? PrstOpis { get; set; }

    public string PrstNazwa { get; set; } = null!;

    public string PrstDirtyOrgId { get; set; } = null!;

    public string PrstOrgId { get; set; } = null!;

    public int PrstZrodgid { get; set; }
}
