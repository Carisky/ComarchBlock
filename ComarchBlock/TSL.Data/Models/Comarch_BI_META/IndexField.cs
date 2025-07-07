using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class IndexField
{
    public int IndfId { get; set; }

    public int IndfIndid { get; set; }

    public int? IndfFldid { get; set; }

    public int IndfOrder { get; set; }

    public virtual Field? IndfFld { get; set; }

    public virtual Index IndfInd { get; set; } = null!;
}
