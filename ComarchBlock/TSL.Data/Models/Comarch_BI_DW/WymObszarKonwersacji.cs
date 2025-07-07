using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymObszarKonwersacji
{
    public int ObkRowId { get; set; }

    public int ObkId { get; set; }

    public int ObkZrodgid { get; set; }

    public string ObkCleanOrgId { get; set; } = null!;

    public string ObkDirtyOrgId { get; set; } = null!;

    public string ObkNazwa { get; set; } = null!;

    public string? ObkOpis { get; set; }

    public string? ObkParDirtyOrgId { get; set; }

    public string? ObkParCleanOrgId { get; set; }

    public int? ObkParGid { get; set; }

    public DateTime ObkTsinsert { get; set; }

    public DateTime ObkTsupdate { get; set; }

    public DateTime ObkTimeFrom { get; set; }

    public DateTime? ObkTimeTo { get; set; }

    public int ObkChecksumKimball1 { get; set; }

    public int ObkChecksumKimball2 { get; set; }

    public int ObkUpdateTransformationId { get; set; }

    public int? ObkUpdateSubTransformationId { get; set; }

    public int ObkInsertTransformationId { get; set; }

    public int? ObkInsertSubTransformationId { get; set; }

    public byte[] ObkRowVersion { get; set; } = null!;

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual WymZrodloDanych ObkZrodg { get; set; } = null!;
}
