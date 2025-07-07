using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class AnalyticObject
{
    public int AobId { get; set; }

    public string AobName { get; set; } = null!;

    public string AobNormName { get; set; } = null!;

    public string AobAotid { get; set; } = null!;

    public int AobLsrcid { get; set; }

    public DateTime AobTsInsert { get; set; }

    public DateTime AobTsUpdate { get; set; }

    public byte[] AobRowVersion { get; set; } = null!;

    public bool AobIsAvailable { get; set; }

    public bool AobImport { get; set; }

    public bool AobIsImported { get; set; }

    public int? AobLevels { get; set; }

    public string? AobOrgId { get; set; }

    public string? AobStructName { get; set; }

    public string? AobTranslationsSql { get; set; }

    public bool AobIsTranslationsSqlEnabled { get; set; }

    public virtual AnalyticObjectType AobAot { get; set; } = null!;

    public virtual LogicalSource AobLsrc { get; set; } = null!;

    public virtual ICollection<DynamicColumnNode> DynamicColumnNodes { get; set; } = new List<DynamicColumnNode>();
}
