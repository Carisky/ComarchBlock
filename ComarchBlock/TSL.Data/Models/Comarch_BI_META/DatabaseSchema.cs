using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DatabaseSchema
{
    public int DbsId { get; set; }

    public int DbsDbnid { get; set; }

    public string DbsSchema { get; set; } = null!;

    public virtual DatabaseName DbsDbn { get; set; } = null!;

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
}
