using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DatabaseAuthorizationType
{
    public string DatId { get; set; } = null!;

    public string DatName { get; set; } = null!;

    public virtual ICollection<DatabaseAccess> DatabaseAccesses { get; set; } = new List<DatabaseAccess>();
}
