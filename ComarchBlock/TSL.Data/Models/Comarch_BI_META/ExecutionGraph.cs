using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class ExecutionGraph
{
    public int ExgId { get; set; }

    public int ExgEtlPackage { get; set; }

    public DateTime ExgTsinsert { get; set; }

    public DateTime ExgTsupdate { get; set; }

    public string ExgName { get; set; } = null!;

    public bool ExgIsDefault { get; set; }

    public int? ExgMaxDegreeOfParallelism { get; set; }

    public virtual ICollection<ExecutionGraphNode> ExecutionGraphNodes { get; set; } = new List<ExecutionGraphNode>();

    public virtual EtlNode ExgEtlPackageNavigation { get; set; } = null!;
}
