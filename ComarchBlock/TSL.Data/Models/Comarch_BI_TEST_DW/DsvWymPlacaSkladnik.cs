using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymPlacaSkladnik
{
    public int PskChecksumKimball1 { get; set; }

    public int PskChecksumKimball2 { get; set; }

    public string PskDirtyOrgId { get; set; } = null!;

    public int PskId { get; set; }

    public int PskInsertSubTransformationId { get; set; }

    public int? PskInsertTransformationId { get; set; }

    public string PskNazwa { get; set; } = null!;

    public string? PskOpis { get; set; }

    public string PskOrgId { get; set; } = null!;

    public string? PskParCleanOrgId { get; set; }

    public string? PskParDirtyOrgId { get; set; }

    public string? PskParent { get; set; }

    public int? PskParGid { get; set; }

    public bool? PskPracodawca { get; set; }

    public int? PskRowId { get; set; }

    public byte[] PskRowVersion { get; set; } = null!;

    public DateTime PskTimeFrom { get; set; }

    public DateTime? PskTimeTo { get; set; }

    public DateTime PskTsinsert { get; set; }

    public DateTime PskTsupdate { get; set; }

    public int PskUpdateSubTransformationId { get; set; }

    public int? PskUpdateTransformationId { get; set; }

    public int PskZrodgid { get; set; }
}
