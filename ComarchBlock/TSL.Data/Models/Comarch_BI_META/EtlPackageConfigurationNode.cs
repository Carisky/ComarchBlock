using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlPackageConfigurationNode
{
    public int EtlcnId { get; set; }

    public int EtlcnEtlnid { get; set; }

    public bool EtlcnIsEnabled { get; set; }

    public DateTime EtlcnTsinsert { get; set; }

    public DateTime EtlcnTsupdate { get; set; }

    public byte[] EtlcnRowVersion { get; set; } = null!;

    public string? EtlcnSqlCommandText { get; set; }

    public bool EtlcnExecInSourceDb { get; set; }

    public int? EtlcnEtlcnidparent { get; set; }

    public int EtlcnEtlpcid { get; set; }

    public virtual ICollection<EtlPackageConfiguration> EtlPackageConfigurations { get; set; } = new List<EtlPackageConfiguration>();

    public virtual EtlPackageConfigurationNode? EtlcnEtlcnidparentNavigation { get; set; }

    public virtual EtlNode EtlcnEtln { get; set; } = null!;

    public virtual ICollection<EtlPackageConfigurationNode> InverseEtlcnEtlcnidparentNavigation { get; set; } = new List<EtlPackageConfigurationNode>();
}
