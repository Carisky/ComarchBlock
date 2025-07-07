using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class FactFieldKind
{
    public string FfkId { get; set; } = null!;

    public string FfkName { get; set; } = null!;

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
