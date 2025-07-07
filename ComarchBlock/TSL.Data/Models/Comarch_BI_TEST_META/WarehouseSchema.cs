using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class WarehouseSchema
{
    public int WsId { get; set; }

    public string WsName { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
