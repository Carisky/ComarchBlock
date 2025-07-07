using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymSekcjeGu
{
    public int SekRowId { get; set; }

    public int SekId { get; set; }

    public int SekZrodgid { get; set; }

    public string SekOrgId { get; set; } = null!;

    public string SekDirtyOrgId { get; set; } = null!;

    public string SekNazwa { get; set; } = null!;

    public string? SekOpis { get; set; }

    public string? SekParDirtyOrgId { get; set; }

    public string? SekParOrgId { get; set; }

    public int? SekParGid { get; set; }

    public DateTime SekTsinsert { get; set; }

    public DateTime SekTsupdate { get; set; }

    public DateTime SekTimeFrom { get; set; }

    public DateTime? SekTimeTo { get; set; }

    public int SekChecksumKimball1 { get; set; }

    public int SekChecksumKimball2 { get; set; }

    public int SekUpdateTransformationId { get; set; }

    public int? SekUpdateSubTransformationId { get; set; }

    public int SekInsertTransformationId { get; set; }

    public int? SekInsertSubTransformationId { get; set; }

    public byte[] SekRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych SekZrodg { get; set; } = null!;

    public virtual ICollection<WymDzialyGu> WymDzialyGus { get; set; } = new List<WymDzialyGu>();
}
