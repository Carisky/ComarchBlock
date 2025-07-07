using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlNodeType
{
    public string EntId { get; set; } = null!;

    public string EntName { get; set; } = null!;

    public virtual ICollection<EtlNode> EtlNodes { get; set; } = new List<EtlNode>();
}
