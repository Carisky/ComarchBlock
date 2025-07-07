using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class TableType
{
    public string TbtId { get; set; } = null!;

    public string TbtName { get; set; } = null!;

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();

    public virtual ICollection<TableLink> TableLinks { get; set; } = new List<TableLink>();
}
