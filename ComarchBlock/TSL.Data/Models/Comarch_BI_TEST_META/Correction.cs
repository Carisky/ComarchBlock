using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Correction
{
    public int CorId { get; set; }

    public string CorName { get; set; } = null!;

    public string CorCreator { get; set; } = null!;

    public string CorUpdater { get; set; } = null!;

    public string? CorDescription { get; set; }

    public DateTime CorTsInsert { get; set; }

    public DateTime CorTsUpdate { get; set; }

    public byte[] CorRowVersion { get; set; } = null!;

    public int CorTblid { get; set; }

    public string CorCstid { get; set; } = null!;

    public string? CorRequester { get; set; }

    public string? CorCtpid { get; set; }

    public DateTime? CorFrom { get; set; }

    public DateTime? CorTo { get; set; }

    public bool CorIsGenerated { get; set; }

    public virtual CorrectionState CorCst { get; set; } = null!;

    public virtual CorrectionType? CorCtp { get; set; }

    public virtual Table CorTbl { get; set; } = null!;

    public virtual ICollection<CorrectionFilter> CorrectionFilters { get; set; } = new List<CorrectionFilter>();

    public virtual ICollection<CorrectionMapping> CorrectionMappings { get; set; } = new List<CorrectionMapping>();

    public virtual ICollection<CorrectionMeasure> CorrectionMeasures { get; set; } = new List<CorrectionMeasure>();
}
