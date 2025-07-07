using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymSekcjeGu
{
    public int SekChecksumKimball1 { get; set; }

    public int SekChecksumKimball2 { get; set; }

    public string SekDirtyOrgId { get; set; } = null!;

    public int SekId { get; set; }

    public int? SekInsertSubTransformationId { get; set; }

    public int SekInsertTransformationId { get; set; }

    public string SekNazwa { get; set; } = null!;

    public string? SekOpis { get; set; }

    public string SekOrgId { get; set; } = null!;

    public string? SekParDirtyOrgId { get; set; }

    public int? SekParGid { get; set; }

    public string? SekParOrgId { get; set; }

    public int? SekRowId { get; set; }

    public byte[] SekRowVersion { get; set; } = null!;

    public DateTime SekTimeFrom { get; set; }

    public DateTime? SekTimeTo { get; set; }

    public DateTime SekTsinsert { get; set; }

    public DateTime SekTsupdate { get; set; }

    public int? SekUpdateSubTransformationId { get; set; }

    public int SekUpdateTransformationId { get; set; }

    public int SekZrodgid { get; set; }
}
