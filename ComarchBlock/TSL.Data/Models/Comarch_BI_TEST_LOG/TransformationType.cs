using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class TransformationType
{
    public string TrntId { get; set; } = null!;

    public string TrntName { get; set; } = null!;

    public virtual ICollection<Transformation> Transformations { get; set; } = new List<Transformation>();
}
