using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymWmsstrukturaMagazynu
{
    public int WmssWmsmgid { get; set; }

    public string WmssWmsmdirtyOrgId { get; set; } = null!;

    public int WmssWmszmgid { get; set; }

    public string WmssWmsmdirtyOrgId1 { get; set; } = null!;

    public int WmssRowId { get; set; }

    public int WmssId { get; set; }

    public int WmssZrodgid { get; set; }

    public string WmssOrgId { get; set; } = null!;

    public string WmssDirtyOrgId { get; set; } = null!;

    public string? WmssNazwa { get; set; }

    public string? WmssOpis { get; set; }

    public string? WmssParDirtyOrgId { get; set; }

    public string? WmssParCleanOrgId { get; set; }

    public int? WmssParGid { get; set; }

    public DateTime WmssTsinsert { get; set; }

    public DateTime WmssTsupdate { get; set; }

    public DateTime WmssTimeFrom { get; set; }

    public DateTime? WmssTimeTo { get; set; }

    public int WmssChecksumKimball1 { get; set; }

    public int WmssChecksumKimball2 { get; set; }

    public int WmssUpdateSubTransformationId { get; set; }

    public int? WmssUpdateTransformationId { get; set; }

    public int WmssInsertSubTransformationId { get; set; }

    public int? WmssInsertTransformationId { get; set; }

    public byte[] WmssRowVersion { get; set; } = null!;

    public string WmssKod { get; set; } = null!;

    public string? WmssPelnyKod { get; set; }

    public int? BudgetMemberId { get; set; }
}
