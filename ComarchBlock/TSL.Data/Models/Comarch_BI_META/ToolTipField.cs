using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ToolTipField
{
    public int TtfId { get; set; }

    public int TtfFldid { get; set; }

    public string TtfLanid { get; set; } = null!;

    public string? TtfDescription { get; set; }

    public virtual Field TtfFld { get; set; } = null!;

    public virtual Language TtfLan { get; set; } = null!;
}
