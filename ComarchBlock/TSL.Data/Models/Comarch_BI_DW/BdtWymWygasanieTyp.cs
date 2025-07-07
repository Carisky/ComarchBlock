using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymWygasanieTyp
{
    public int WygTypId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? WygTypRowId { get; set; }

    public byte[] WygTypRowVersion { get; set; } = null!;

    public int? WygTypInsertTransformationId { get; set; }

    public int WygTypInsertSubTransformationId { get; set; }

    public int? WygTypUpdateTransformationId { get; set; }

    public int WygTypUpdateSubTransformationId { get; set; }

    public int WygTypChecksumKimball2 { get; set; }

    public int WygTypChecksumKimball1 { get; set; }

    public DateTime? WygTypTimeTo { get; set; }

    public DateTime WygTypTimeFrom { get; set; }

    public DateTime WygTypTsupdate { get; set; }

    public DateTime WygTypTsinsert { get; set; }

    public int? WygTypParGid { get; set; }

    public string? WygTypParCleanOrgId { get; set; }

    public string? WygTypParDirtyOrgId { get; set; }

    public string? WygTypOpis { get; set; }

    public string WygTypNazwa { get; set; } = null!;

    public string WygTypDirtyOrgId { get; set; } = null!;

    public string WygTypOrgId { get; set; } = null!;

    public int WygTypZrodgid { get; set; }
}
