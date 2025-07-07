using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class PrimaryKey
{
    public int PrkId { get; set; }

    public int? PrkTblid { get; set; }

    public string PrkLogicalName { get; set; } = null!;

    public virtual ICollection<PrimaryKeyField> PrimaryKeyFields { get; set; } = new List<PrimaryKeyField>();

    public virtual Table? PrkTbl { get; set; }
}
