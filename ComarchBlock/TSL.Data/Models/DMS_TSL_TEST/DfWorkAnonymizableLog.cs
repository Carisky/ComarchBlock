using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkAnonymizableLog
{
    public int AlgId { get; set; }

    public int? AlgDwcid { get; set; }

    public int? AlgXldid { get; set; }

    public int? AlgDwlid { get; set; }

    public int AlgCdcid { get; set; }

    public DateTime AlgDate { get; set; }
}
