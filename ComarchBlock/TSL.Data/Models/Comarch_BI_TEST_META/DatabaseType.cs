using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DatabaseType
{
    public string DbtId { get; set; } = null!;

    public string DbtName { get; set; } = null!;

    public virtual DatabaseAccess? DatabaseAccess { get; set; }
}
