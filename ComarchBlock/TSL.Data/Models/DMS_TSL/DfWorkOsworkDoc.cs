using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkOsworkDoc
{
    public int WooDwdid { get; set; }

    public int WooDcdid { get; set; }

    public bool? WooIsActive { get; set; }

    public byte WooPermissionSource { get; set; }

    public virtual DfConfOsdictionary WooDcd { get; set; } = null!;

    public virtual DfWork WooDwd { get; set; } = null!;
}
