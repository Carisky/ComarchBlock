using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SbCustomQuery
{
    public int ToqId { get; set; }

    public string ToqName { get; set; } = null!;

    public string ToqSqlquery { get; set; } = null!;

    public int ToqObjectType { get; set; }

    public bool? ToqIsRunQuery { get; set; }

    public byte ToqDatabaseType { get; set; }
}
