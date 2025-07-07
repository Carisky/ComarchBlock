using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class EtlComponent
{
    public int EtlcId { get; set; }

    public string EtlcName { get; set; } = null!;

    public string EtlcEctid { get; set; } = null!;

    public string? EtlcSqlCommandText { get; set; }

    public string? EtlcSqlCommandType { get; set; }

    public DateTime EtlcTsinsert { get; set; }

    public DateTime EtlcTsupdate { get; set; }

    public byte[] EtlcRowVersion { get; set; } = null!;

    public int? EtlcPsrcid { get; set; }

    public bool EtlcExecInSourceDb { get; set; }

    public bool EtlcConfigurationSupported { get; set; }

    public int? EtlcWritebackPsrcid { get; set; }

    public string? EtlcDescription { get; set; }

    public string? EtlcSchemaName { get; set; }

    public string? EtlcJsonFilePath { get; set; }

    public bool EtlcUseRest { get; set; }

    public string? EtlcMainUrl { get; set; }

    public string? EtlcQueryUrlExpression { get; set; }

    public virtual ICollection<EtlNode> EtlNodes { get; set; } = new List<EtlNode>();

    public virtual PhysicalSource? EtlcPsrc { get; set; }

    public virtual PhysicalSource? EtlcWritebackPsrc { get; set; }
}
