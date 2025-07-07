using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymDzialyGu
{
    public int DziId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? DziRowId { get; set; }

    public byte[] DziRowVersion { get; set; } = null!;

    public int? DziInsertSubTransformationId { get; set; }

    public int DziInsertTransformationId { get; set; }

    public int? DziUpdateSubTransformationId { get; set; }

    public int DziUpdateTransformationId { get; set; }

    public int DziChecksumKimball2 { get; set; }

    public int DziChecksumKimball1 { get; set; }

    public DateTime? DziTimeTo { get; set; }

    public DateTime DziTimeFrom { get; set; }

    public DateTime DziTsupdate { get; set; }

    public DateTime DziTsinsert { get; set; }

    public int? DziParGid { get; set; }

    public string? DziParOrgId { get; set; }

    public string? DziParDirtyOrgId { get; set; }

    public string? DziOpis { get; set; }

    public string DziNazwa { get; set; } = null!;

    public string DziDirtyOrgId { get; set; } = null!;

    public string DziOrgId { get; set; } = null!;

    public int DziSekid { get; set; }

    public int DziZrodgid { get; set; }
}
