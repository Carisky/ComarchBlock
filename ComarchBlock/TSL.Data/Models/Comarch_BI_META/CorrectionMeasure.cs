using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class CorrectionMeasure
{
    public int CmeId { get; set; }

    public int CmeCorid { get; set; }

    public int CmeFldid { get; set; }

    public bool CmeIsEnabled { get; set; }

    public string? CmeExpression { get; set; }

    public DateTime CmeTsInsert { get; set; }

    public DateTime CmeTsUpdate { get; set; }

    public byte[] CmeRowVersion { get; set; } = null!;

    public virtual Correction CmeCor { get; set; } = null!;

    public virtual Field CmeFld { get; set; } = null!;
}
