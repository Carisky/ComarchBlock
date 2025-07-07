using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymKategoriaAbcxyz
{
    public int AbcChecksumKimball1 { get; set; }

    public int AbcChecksumKimball2 { get; set; }

    public string AbcDirtyOrgId { get; set; } = null!;

    public int AbcId { get; set; }

    public int? AbcInsertSubTransformationId { get; set; }

    public int AbcInsertTransformationId { get; set; }

    public string AbcNazwa { get; set; } = null!;

    public string? AbcOpis { get; set; }

    public string AbcOrgId { get; set; } = null!;

    public string? AbcParCleanOrgId { get; set; }

    public string? AbcParDirtyOrgId { get; set; }

    public int? AbcParGid { get; set; }

    public int? AbcRowId { get; set; }

    public byte[] AbcRowVersion { get; set; } = null!;

    public DateTime AbcTimeFrom { get; set; }

    public DateTime? AbcTimeTo { get; set; }

    public string? AbcTowarRodzaj { get; set; }

    public DateTime AbcTsinsert { get; set; }

    public DateTime AbcTsupdate { get; set; }

    public int? AbcUpdateSubTransformationId { get; set; }

    public int AbcUpdateTransformationId { get; set; }

    public int AbcZrodgid { get; set; }
}
