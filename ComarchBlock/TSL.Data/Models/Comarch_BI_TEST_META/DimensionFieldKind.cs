using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DimensionFieldKind
{
    public string DfkId { get; set; } = null!;

    public string DfkName { get; set; } = null!;

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
