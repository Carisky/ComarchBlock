using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlParameterSet
{
    public int EpsId { get; set; }

    public string EpsName { get; set; } = null!;

    public DateTime EpsTsinsert { get; set; }

    public DateTime EpsTsupdate { get; set; }

    public byte[] EpsRowVersion { get; set; } = null!;

    public string? EpsDescription { get; set; }

    public virtual ICollection<EtlPackageConfiguration> EtlPackageConfigurations { get; set; } = new List<EtlPackageConfiguration>();

    public virtual ICollection<EtlParameterValue> EtlParameterValues { get; set; } = new List<EtlParameterValue>();
}
