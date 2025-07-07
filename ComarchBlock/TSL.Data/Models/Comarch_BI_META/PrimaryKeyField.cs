using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class PrimaryKeyField
{
    public int PrkfId { get; set; }

    public int PrkfPrkid { get; set; }

    public int? PrkfFldid { get; set; }

    public int PrkfIndex { get; set; }

    public virtual Field? PrkfFld { get; set; }

    public virtual PrimaryKey PrkfPrk { get; set; } = null!;
}
