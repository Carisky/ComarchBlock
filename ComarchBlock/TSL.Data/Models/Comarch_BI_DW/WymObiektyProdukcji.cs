using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymObiektyProdukcji
{
    public int ObpChecksumKimball1 { get; set; }

    public int ObpChecksumKimball2 { get; set; }

    public string ObpDirtyOrgId { get; set; } = null!;

    public int ObpId { get; set; }

    public int? ObpInsertSubTransformationId { get; set; }

    public int ObpInsertTransformationId { get; set; }

    public string ObpOrgId { get; set; } = null!;

    public string? ObpParDirtyOrgId { get; set; }

    public int? ObpParId { get; set; }

    public string ObpParOrgId { get; set; } = null!;

    public int ObpRowId { get; set; }

    public byte[] ObpRowVersion { get; set; } = null!;

    public DateTime ObpTimeFrom { get; set; }

    public DateTime? ObpTimeTo { get; set; }

    public DateTime ObpTsinsert { get; set; }

    public DateTime ObpTsupdate { get; set; }

    public int? ObpUpdateSubTransformationId { get; set; }

    public int ObpUpdateTransformationId { get; set; }

    public int ObpZrodgid { get; set; }

    public string ObpNazwa { get; set; } = null!;

    public string? ObpOpis { get; set; }

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual WymZrodloDanych ObpZrodg { get; set; } = null!;
}
