using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymPreliminarz
{
    public int? PrlvRowId { get; set; }

    public int PrlvId { get; set; }

    public int PrlvZrodgid { get; set; }

    public string PrlvOrgId { get; set; } = null!;

    public string PrlvDirtyOrgId { get; set; } = null!;

    public string? PrlvParCleanOrgId { get; set; }

    public string? PrlvParDirtyOrgId { get; set; }

    public int? PrlvParGid { get; set; }

    public string PrlvNazwa { get; set; } = null!;

    public string? PrlvOpis { get; set; }

    public DateTime PrlvTsinsert { get; set; }

    public DateTime PrlvTsupdate { get; set; }

    public int? PrlvUpdateTransformationId { get; set; }

    public int PrlvUpdateSubTransformationId { get; set; }

    public int? PrlvInsertTransformationId { get; set; }

    public int PrlvInsertSubTransformationId { get; set; }

    public DateTime PrlvTimeFrom { get; set; }

    public DateTime? PrlvTimeTo { get; set; }

    public int PrlvChecksumKimball1 { get; set; }

    public int PrlvChecksumKimball2 { get; set; }

    public byte[] PrlvRowVersion { get; set; } = null!;

    public string? PrlvDokumentObcy { get; set; }
}
