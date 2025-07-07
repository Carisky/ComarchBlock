using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class TargetFktTable
{
    public int? TfTgId { get; set; }

    public string TfFktTableName { get; set; } = null!;

    public virtual Target? TfTg { get; set; }
}
