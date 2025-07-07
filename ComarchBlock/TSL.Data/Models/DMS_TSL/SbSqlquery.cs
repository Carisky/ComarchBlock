using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class SbSqlquery
{
    public int TosId { get; set; }

    public string TosName { get; set; } = null!;

    public int TosDcdid { get; set; }

    public string TosSqlquery { get; set; } = null!;

    public bool? TosArchival { get; set; }

    public DateTime TosCreateDate { get; set; }
}
