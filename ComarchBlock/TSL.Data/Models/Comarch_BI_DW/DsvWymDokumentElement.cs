using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymDokumentElement
{
    public int? DokElemRowId { get; set; }

    public int DokElemId { get; set; }

    public int DokElemZrodgid { get; set; }

    public string DokElemOrgId { get; set; } = null!;

    public string DokElemDirtyOrgId { get; set; } = null!;

    public string? DokElemParCleanOrgId { get; set; }

    public string? DokElemParDirtyOrgId { get; set; }

    public int? DokElemParGid { get; set; }

    public string DokElemNazwa { get; set; } = null!;

    public string? DokElemOpis { get; set; }

    public DateTime DokElemTsinsert { get; set; }

    public DateTime DokElemTsupdate { get; set; }

    public int? DokElemUpdateTransformationId { get; set; }

    public int DokElemUpdateSubTransformationId { get; set; }

    public int? DokElemInsertTransformationId { get; set; }

    public int DokElemInsertSubTransformationId { get; set; }

    public DateTime DokElemTimeFrom { get; set; }

    public DateTime? DokElemTimeTo { get; set; }

    public int DokElemChecksumKimball1 { get; set; }

    public int DokElemChecksumKimball2 { get; set; }

    public byte[] DokElemRowVersion { get; set; } = null!;

    public string? DokElemPozycja { get; set; }
}
