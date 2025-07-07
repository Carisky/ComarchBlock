using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymGrati
{
    public int GrtChecksumKimball1 { get; set; }

    public int GrtChecksumKimball2 { get; set; }

    public string GrtDirtyOrgId { get; set; } = null!;

    public int GrtId { get; set; }

    public int? GrtInsertSubTransformationId { get; set; }

    public int GrtInsertTransformationId { get; set; }

    public string GrtNazwa { get; set; } = null!;

    public string? GrtOpis { get; set; }

    public string GrtOrgId { get; set; } = null!;

    public string? GrtParCleanOrgId { get; set; }

    public string? GrtParDirtyOrgId { get; set; }

    public int? GrtParGid { get; set; }

    public int? GrtRowId { get; set; }

    public byte[] GrtRowVersion { get; set; } = null!;

    public DateTime GrtTimeFrom { get; set; }

    public DateTime? GrtTimeTo { get; set; }

    public DateTime GrtTsinsert { get; set; }

    public DateTime GrtTsupdate { get; set; }

    public int? GrtUpdateSubTransformationId { get; set; }

    public int GrtUpdateTransformationId { get; set; }

    public int GrtZrodgid { get; set; }
}
