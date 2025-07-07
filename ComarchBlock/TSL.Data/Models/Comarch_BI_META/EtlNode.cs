using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlNode
{
    public int EtlnId { get; set; }

    public int? EtlnParentEtlnid { get; set; }

    public string EtlnEntid { get; set; } = null!;

    public string EtlnName { get; set; } = null!;

    public bool EtlnIsDisabled { get; set; }

    public int? EtlnEtlcid { get; set; }

    public int? EtlnDtlnid { get; set; }

    public DateTime EtlnTsinsert { get; set; }

    public DateTime EtlnTsupdate { get; set; }

    public byte[] EtlnRowVersion { get; set; } = null!;

    public int? EtlnPsrcid { get; set; }

    public string? EtlnRelatedOlapCubes { get; set; }

    public int? EtlnMaxConcurrentExecutables { get; set; }

    public string? EtlnParallelPackagesSavePath { get; set; }

    public int EtlnIndex { get; set; }

    public bool EtlnSkipExecution { get; set; }

    public virtual ICollection<EtlPackageConfigurationNode> EtlPackageConfigurationNodes { get; set; } = new List<EtlPackageConfigurationNode>();

    public virtual TableLink? EtlnDtln { get; set; }

    public virtual EtlNodeType EtlnEnt { get; set; } = null!;

    public virtual EtlComponent? EtlnEtlc { get; set; }

    public virtual EtlNode? EtlnParentEtln { get; set; }

    public virtual PhysicalSource? EtlnPsrc { get; set; }

    public virtual ICollection<ExecutionGraphNode> ExecutionGraphNodes { get; set; } = new List<ExecutionGraphNode>();

    public virtual ICollection<ExecutionGraph> ExecutionGraphs { get; set; } = new List<ExecutionGraph>();

    public virtual ICollection<EtlNode> InverseEtlnParentEtln { get; set; } = new List<EtlNode>();
}
