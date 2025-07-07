using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ForeignKeyDisplay
{
    public int FkdId { get; set; }

    public int FkdTblid { get; set; }

    public int FkdFldid { get; set; }

    public int FkdDisplayOrder { get; set; }

    public virtual Field FkdFld { get; set; } = null!;

    public virtual Table FkdTbl { get; set; } = null!;
}
