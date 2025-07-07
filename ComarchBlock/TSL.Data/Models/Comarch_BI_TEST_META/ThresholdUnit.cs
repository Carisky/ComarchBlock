using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class ThresholdUnit
{
    public string TsuId { get; set; } = null!;

    public string TsuName { get; set; } = null!;

    public virtual ICollection<TableLink> TableLinks { get; set; } = new List<TableLink>();
}
