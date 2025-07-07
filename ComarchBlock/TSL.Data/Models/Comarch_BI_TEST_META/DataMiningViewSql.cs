using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DataMiningViewSql
{
    public int DmvsId { get; set; }

    public string? DmvsSqlStatement { get; set; }

    public string DmvsDmmname { get; set; } = null!;

    public string? DmvsDescription { get; set; }

    public string DmvsDefaultSqlStatement { get; set; } = null!;

    public string DmvsName { get; set; } = null!;
}
