using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktNarzedziownium
{
    public int NrzTerminWydania { get; set; }

    public int NrzPrcGid { get; set; }

    public int NrzNdzgid { get; set; }

    public int NrzTerminZdania { get; set; }

    public int NrzDokRwlikwidacji { get; set; }

    public int NrzDokRwzdania { get; set; }

    public int NrzDokRwwydania { get; set; }

    public int NrzId { get; set; }

    public int NrzZrodgid { get; set; }

    public int NrzCzdgid { get; set; }

    public string NrzOrgId { get; set; } = null!;

    public string NrzDirtyOrgId { get; set; } = null!;

    public string? NrzOpis { get; set; }

    public DateTime NrzTsinsert { get; set; }

    public DateTime NrzTsupdate { get; set; }

    public int NrzUpdateSubTransformationId { get; set; }

    public int? NrzUpdateTransformationId { get; set; }

    public int NrzInsertSubTransformationId { get; set; }

    public int? NrzInsertTransformationId { get; set; }

    public int? NrzCzasWydania { get; set; }

    public int? NrzPlanowanyCzasWydania { get; set; }
}
