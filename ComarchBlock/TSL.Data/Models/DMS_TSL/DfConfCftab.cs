using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCftab
{
    public int CfcId { get; set; }

    public string CfcName { get; set; } = null!;

    public int CfcDshid { get; set; }

    public int CfcPosition { get; set; }

    public bool CfcArchival { get; set; }
}
