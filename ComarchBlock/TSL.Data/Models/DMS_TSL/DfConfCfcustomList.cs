using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfcustomList
{
    public int DclId { get; set; }

    public int DclType { get; set; }

    public string DclName { get; set; } = null!;

    public string? DclSqlQuery { get; set; }
}
