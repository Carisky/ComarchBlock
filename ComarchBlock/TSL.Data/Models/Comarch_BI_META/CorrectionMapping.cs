using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class CorrectionMapping
{
    public int CmaId { get; set; }

    public int CmaCorid { get; set; }

    public int CmaFldid { get; set; }

    public string CmaOldValue { get; set; } = null!;

    public string CmaNewValue { get; set; } = null!;

    public bool CmaIsEnabled { get; set; }

    public int? CmaDfldid { get; set; }

    public DateTime CmaTsInsert { get; set; }

    public DateTime CmaTsUpdate { get; set; }

    public byte[] CmaRowVersion { get; set; } = null!;

    public virtual Correction CmaCor { get; set; } = null!;

    public virtual Field? CmaDfld { get; set; }

    public virtual Field CmaFld { get; set; } = null!;
}
