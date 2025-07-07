using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymAlokacja
{
    public int AlokacjaChecksumKimball1 { get; set; }

    public int AlokacjaChecksumKimball2 { get; set; }

    public string AlokacjaDirtyOrgId { get; set; } = null!;

    public int AlokacjaId { get; set; }

    public int? AlokacjaInsertSubTransformationId { get; set; }

    public int AlokacjaInsertTransformationId { get; set; }

    public string AlokacjaNazwa { get; set; } = null!;

    public string? AlokacjaOpis { get; set; }

    public string AlokacjaOrgId { get; set; } = null!;

    public string? AlokacjaParCleanOrgId { get; set; }

    public string? AlokacjaParDirtyOrgId { get; set; }

    public int? AlokacjaParGid { get; set; }

    public int? AlokacjaRowId { get; set; }

    public byte[] AlokacjaRowVersion { get; set; } = null!;

    public DateTime AlokacjaTimeFrom { get; set; }

    public DateTime? AlokacjaTimeTo { get; set; }

    public DateTime AlokacjaTsinsert { get; set; }

    public DateTime AlokacjaTsupdate { get; set; }

    public int? AlokacjaUpdateSubTransformationId { get; set; }

    public int AlokacjaUpdateTransformationId { get; set; }

    public int AlokacjaZrodgid { get; set; }
}
