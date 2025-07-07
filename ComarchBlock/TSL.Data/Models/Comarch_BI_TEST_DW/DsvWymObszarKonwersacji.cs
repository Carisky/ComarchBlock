using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymObszarKonwersacji
{
    public int ObkChecksumKimball1 { get; set; }

    public int ObkChecksumKimball2 { get; set; }

    public string ObkCleanOrgId { get; set; } = null!;

    public string ObkDirtyOrgId { get; set; } = null!;

    public int ObkId { get; set; }

    public int? ObkInsertSubTransformationId { get; set; }

    public int ObkInsertTransformationId { get; set; }

    public string ObkNazwa { get; set; } = null!;

    public string? ObkOpis { get; set; }

    public string? ObkParCleanOrgId { get; set; }

    public string? ObkParDirtyOrgId { get; set; }

    public int? ObkParGid { get; set; }

    public int? ObkRowId { get; set; }

    public byte[] ObkRowVersion { get; set; } = null!;

    public DateTime ObkTimeFrom { get; set; }

    public DateTime? ObkTimeTo { get; set; }

    public DateTime ObkTsinsert { get; set; }

    public DateTime ObkTsupdate { get; set; }

    public int? ObkUpdateSubTransformationId { get; set; }

    public int ObkUpdateTransformationId { get; set; }

    public int ObkZrodgid { get; set; }
}
