using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymObiektyProdukcji
{
    public int ObpId { get; set; }

    public int? BudgetMemberId { get; set; }

    public int? ObpRowId { get; set; }

    public string? ObpOpis { get; set; }

    public string ObpNazwa { get; set; } = null!;

    public int ObpZrodgid { get; set; }

    public int ObpUpdateTransformationId { get; set; }

    public int? ObpUpdateSubTransformationId { get; set; }

    public DateTime ObpTsupdate { get; set; }

    public DateTime ObpTsinsert { get; set; }

    public DateTime? ObpTimeTo { get; set; }

    public DateTime ObpTimeFrom { get; set; }

    public byte[] ObpRowVersion { get; set; } = null!;

    public string ObpParOrgId { get; set; } = null!;

    public int? ObpParId { get; set; }

    public string? ObpParDirtyOrgId { get; set; }

    public string ObpOrgId { get; set; } = null!;

    public int ObpInsertTransformationId { get; set; }

    public int? ObpInsertSubTransformationId { get; set; }

    public string ObpDirtyOrgId { get; set; } = null!;

    public int ObpChecksumKimball2 { get; set; }

    public int ObpChecksumKimball1 { get; set; }
}
