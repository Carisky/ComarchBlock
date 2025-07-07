using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class SourceType
{
    public string SrtId { get; set; } = null!;

    public string SrtName { get; set; } = null!;

    public virtual ICollection<PhysicalSource> PhysicalSources { get; set; } = new List<PhysicalSource>();
}
