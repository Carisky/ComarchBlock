using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfReportsWorkflowTypesAccess
{
    public int RwaRptid { get; set; }

    public int RwaDfhid { get; set; }

    public byte RwaType { get; set; }

    public bool RwaArchival { get; set; }

    public virtual DfHeadDokumentFlow RwaDfh { get; set; } = null!;

    public virtual DfReport RwaRpt { get; set; } = null!;
}
