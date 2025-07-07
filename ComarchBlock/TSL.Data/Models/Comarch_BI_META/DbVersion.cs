using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DbVersion
{
    public int Version { get; set; }

    public string Release { get; set; } = null!;

    public DateTime PatchCreationDate { get; set; }

    public DateTime PatchExecutionDate { get; set; }
}
