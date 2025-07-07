using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkCfworkflowDocument
{
    public int DwwDwcid { get; set; }

    public int DwwDwdid { get; set; }

    public int DwwArchival { get; set; }

    public DateTime? DwwModificationData { get; set; }

    public int? DwwDdsid { get; set; }

    public int? DwwDcdid { get; set; }

    public virtual DfWorkCf DwwDwc { get; set; } = null!;

    public virtual DfWork DwwDwd { get; set; } = null!;
}
