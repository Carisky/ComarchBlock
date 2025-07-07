using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymDokumentPlatnosc
{
    public int? DokPlaRowId { get; set; }

    public int DokPlaId { get; set; }

    public int DokPlaZrodgid { get; set; }

    public string DokPlaOrgId { get; set; } = null!;

    public string DokPlaDirtyOrgId { get; set; } = null!;

    public string? DokPlaParCleanOrgId { get; set; }

    public string? DokPlaParDirtyOrgId { get; set; }

    public int? DokPlaParGid { get; set; }

    public string DokPlaNazwa { get; set; } = null!;

    public string? DokPlaOpis { get; set; }

    public DateTime DokPlaTsinsert { get; set; }

    public DateTime DokPlaTsupdate { get; set; }

    public int? DokPlaUpdateTransformationId { get; set; }

    public int DokPlaUpdateSubTransformationId { get; set; }

    public int? DokPlaInsertTransformationId { get; set; }

    public int DokPlaInsertSubTransformationId { get; set; }

    public DateTime DokPlaTimeFrom { get; set; }

    public DateTime? DokPlaTimeTo { get; set; }

    public int DokPlaChecksumKimball1 { get; set; }

    public int DokPlaChecksumKimball2 { get; set; }

    public byte[] DokPlaRowVersion { get; set; } = null!;
}
