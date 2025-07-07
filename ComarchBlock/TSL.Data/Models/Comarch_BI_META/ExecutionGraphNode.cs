using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ExecutionGraphNode
{
    public int ExgnId { get; set; }

    public int? ExgnPackage { get; set; }

    public DateTime ExgnTsinsert { get; set; }

    public DateTime ExgnTsupdate { get; set; }

    public int ExgnExgid { get; set; }

    public virtual ExecutionGraph ExgnExg { get; set; } = null!;

    public virtual EtlNode? ExgnPackageNavigation { get; set; }

    public virtual ICollection<ExecutionGraphNode> EgnsExgnidAntecedents { get; set; } = new List<ExecutionGraphNode>();

    public virtual ICollection<ExecutionGraphNode> EgnsExgns { get; set; } = new List<ExecutionGraphNode>();
}
