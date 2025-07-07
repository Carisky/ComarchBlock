using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class CorrectionFilter
{
    public int CfiId { get; set; }

    public int CfiCorid { get; set; }

    public int CfiFldid { get; set; }

    public string CfiValue { get; set; } = null!;

    public bool CfiIsEnabled { get; set; }

    public int? CfiDfldid { get; set; }

    public DateTime CfiTsInsert { get; set; }

    public DateTime CfiTsUpdate { get; set; }

    public byte[] CfiRowVersion { get; set; } = null!;

    public virtual Correction CfiCor { get; set; } = null!;

    public virtual Field? CfiDfld { get; set; }

    public virtual Field CfiFld { get; set; } = null!;
}
