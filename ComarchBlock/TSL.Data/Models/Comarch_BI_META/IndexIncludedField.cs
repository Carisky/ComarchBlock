using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class IndexIncludedField
{
    public int IndiId { get; set; }

    public int IndiIndid { get; set; }

    public int? IndiFldid { get; set; }

    public virtual Field? IndiFld { get; set; }

    public virtual Index IndiInd { get; set; } = null!;
}
