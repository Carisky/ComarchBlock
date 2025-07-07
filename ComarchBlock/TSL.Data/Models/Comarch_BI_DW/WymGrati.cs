using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymGrati
{
    public int GrtRowId { get; set; }

    public int GrtId { get; set; }

    public int GrtZrodgid { get; set; }

    public string GrtOrgId { get; set; } = null!;

    public string GrtDirtyOrgId { get; set; } = null!;

    public string GrtNazwa { get; set; } = null!;

    public string? GrtOpis { get; set; }

    public string? GrtParDirtyOrgId { get; set; }

    public string? GrtParCleanOrgId { get; set; }

    public int? GrtParGid { get; set; }

    public DateTime GrtTsinsert { get; set; }

    public DateTime GrtTsupdate { get; set; }

    public DateTime GrtTimeFrom { get; set; }

    public DateTime? GrtTimeTo { get; set; }

    public int GrtChecksumKimball1 { get; set; }

    public int GrtChecksumKimball2 { get; set; }

    public int GrtUpdateTransformationId { get; set; }

    public int? GrtUpdateSubTransformationId { get; set; }

    public int GrtInsertTransformationId { get; set; }

    public int? GrtInsertSubTransformationId { get; set; }

    public byte[] GrtRowVersion { get; set; } = null!;
}
