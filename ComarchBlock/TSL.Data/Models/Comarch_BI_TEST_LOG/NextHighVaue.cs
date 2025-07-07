using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class NextHighVaue
{
    public int? Sessions { get; set; }

    public int? Transformations { get; set; }

    public int? Processes { get; set; }

    public int? ProcessEvents { get; set; }

    public int? EtlImportResults { get; set; }
}
