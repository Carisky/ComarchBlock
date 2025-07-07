using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class LogicalSource
{
    public int LsrtId { get; set; }

    public int LsrtDepid { get; set; }

    public string LsrtSrcorgId { get; set; } = null!;

    public string LsrtName { get; set; } = null!;

    public string? LsrtDecription { get; set; }

    public bool LsrtIsCentral { get; set; }

    public string LsrtAcronym { get; set; } = null!;

    public DateTime LsrtTsinsert { get; set; }

    public DateTime LsrtTsupdate { get; set; }

    public byte[] LsrtRowVersion { get; set; } = null!;

    public bool LsrtIsPattern { get; set; }

    public string? LsrtHaspServerName { get; set; }

    public bool LsrtIsXlcTemplate { get; set; }

    public virtual ICollection<AnalyticObject> AnalyticObjects { get; set; } = new List<AnalyticObject>();

    public virtual ICollection<EtlPackageConfiguration> EtlPackageConfigurations { get; set; } = new List<EtlPackageConfiguration>();

    public virtual Department LsrtDep { get; set; } = null!;

    public virtual ICollection<PhysicalSource> PhysicalSources { get; set; } = new List<PhysicalSource>();
}
