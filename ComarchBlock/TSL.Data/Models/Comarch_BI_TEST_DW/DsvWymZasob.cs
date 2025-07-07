using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymZasob
{
    public int? ZasRowId { get; set; }

    public int ZasId { get; set; }

    public int ZasZrodgid { get; set; }

    public string ZasOrgId { get; set; } = null!;

    public string ZasDirtyOrgId { get; set; } = null!;

    public string ZasNazwa { get; set; } = null!;

    public string? ZasOpis { get; set; }

    public string? ZasParDirtyOrgId { get; set; }

    public string? ZasParCleanOrgId { get; set; }

    public int? ZasParGid { get; set; }

    public DateTime ZasTsinsert { get; set; }

    public DateTime ZasTsupdate { get; set; }

    public DateTime ZasTimeFrom { get; set; }

    public DateTime? ZasTimeTo { get; set; }

    public int ZasChecksumKimball1 { get; set; }

    public int ZasChecksumKimball2 { get; set; }

    public int ZasUpdateSubTransformationId { get; set; }

    public int? ZasUpdateTransformationId { get; set; }

    public int ZasInsertSubTransformationId { get; set; }

    public int? ZasInsertTransformationId { get; set; }

    public byte[] ZasRowVersion { get; set; } = null!;

    public string? ZasRodzajZasobu { get; set; }
}
