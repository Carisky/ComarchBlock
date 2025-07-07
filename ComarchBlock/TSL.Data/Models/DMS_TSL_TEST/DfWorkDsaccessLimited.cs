using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkDsaccessLimited
{
    public int EsaDwsid { get; set; }

    public int EsaDcdid { get; set; }

    public virtual DfConfOsdictionary EsaDcd { get; set; } = null!;

    public virtual DfWorkD EsaDws { get; set; } = null!;
}
