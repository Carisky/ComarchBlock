using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class EtlParameter
{
    public int EprmId { get; set; }

    public string EprmName { get; set; } = null!;

    public string? EprmDesc { get; set; }

    public DateTime EprmTsinsert { get; set; }

    public DateTime EprmTsupdate { get; set; }

    public byte[] EprmRowVersion { get; set; } = null!;

    public string? EprmTechnicalName { get; set; }

    public string? EprmDefaultValue { get; set; }

    public string EprmEpdtid { get; set; } = null!;

    public bool EprmIsVisibleToEndUser { get; set; }

    public virtual ICollection<EtlParameterValue> EtlParameterValues { get; set; } = new List<EtlParameterValue>();
}
