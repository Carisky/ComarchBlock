using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class AnalyticObjectType
{
    public string AotId { get; set; } = null!;

    public string AotName { get; set; } = null!;

    public virtual ICollection<AnalyticObject> AnalyticObjects { get; set; } = new List<AnalyticObject>();

    public virtual ICollection<DynamicColumnNode> DynamicColumnNodes { get; set; } = new List<DynamicColumnNode>();
}
