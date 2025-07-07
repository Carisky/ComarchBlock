using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class TableGroup
{
    public int TgrId { get; set; }

    public string TgrName { get; set; } = null!;

    public int? TgrTgrid { get; set; }

    public virtual ICollection<TableGroup> InverseTgrTgr { get; set; } = new List<TableGroup>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();

    public virtual TableGroup? TgrTgr { get; set; }
}
