using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvWymWniosek
{
    public int WnoRowId { get; set; }

    public int WnoId { get; set; }

    public int WnoZrodgid { get; set; }

    public string WnoOrgId { get; set; } = null!;

    public string WnoDirtyOrgId { get; set; } = null!;

    public string WnoNazwa { get; set; } = null!;

    public string? WnoOpis { get; set; }

    public string? WnoParDirtyOrgId { get; set; }

    public string? WnoParCleanOrgId { get; set; }

    public int? WnoParGid { get; set; }

    public DateTime WnoTsinsert { get; set; }

    public DateTime WnoTsupdate { get; set; }

    public DateTime WnoTimeFrom { get; set; }

    public DateTime? WnoTimeTo { get; set; }

    public int WnoChecksumKimball1 { get; set; }

    public int WnoChecksumKimball2 { get; set; }

    public int WnoUpdateSubTransformationId { get; set; }

    public int? WnoUpdateTransformationId { get; set; }

    public int WnoInsertSubTransformationId { get; set; }

    public int? WnoInsertTransformationId { get; set; }

    public byte[] WnoRowVersion { get; set; } = null!;

    public string? WnoStatus { get; set; }

    public string? WnoTyp { get; set; }

    public string? WnoPelnyNumer { get; set; }
}
