using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Version
{
    public int MvrId { get; set; }

    public string MvrName { get; set; } = null!;

    public DateTime MvrTsinsert { get; set; }
}
