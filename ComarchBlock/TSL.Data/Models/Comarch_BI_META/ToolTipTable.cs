using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ToolTipTable
{
    public int TttId { get; set; }

    public int TttTblid { get; set; }

    public string TttLanid { get; set; } = null!;

    public string? TttDescription { get; set; }

    public virtual Language TttLan { get; set; } = null!;

    public virtual Table TttTbl { get; set; } = null!;
}
