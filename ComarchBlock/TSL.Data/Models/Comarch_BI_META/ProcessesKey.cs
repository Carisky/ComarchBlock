using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ProcessesKey
{
    public int PrkPrcId { get; set; }

    public int PrkKeyId { get; set; }

    public string PrkKeyTableName { get; set; } = null!;

    public virtual Key PrkKey { get; set; } = null!;

    public virtual Process PrkPrc { get; set; } = null!;
}
