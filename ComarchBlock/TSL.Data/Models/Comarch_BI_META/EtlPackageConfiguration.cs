using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlPackageConfiguration
{
    public int EtlpcId { get; set; }

    public int EtlpcLsrid { get; set; }

    public string EtlpcName { get; set; } = null!;

    public DateTime EtlpcTsinsert { get; set; }

    public DateTime EtlpcTsupdate { get; set; }

    public byte[] EtlpcRowVersion { get; set; } = null!;

    public int EtlpcEpsid { get; set; }

    public int EtlpcEtlcnid { get; set; }

    public virtual EtlParameterSet EtlpcEps { get; set; } = null!;

    public virtual EtlPackageConfigurationNode EtlpcEtlcn { get; set; } = null!;

    public virtual LogicalSource EtlpcLsr { get; set; } = null!;
}
