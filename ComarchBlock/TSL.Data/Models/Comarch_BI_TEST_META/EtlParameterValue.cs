using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class EtlParameterValue
{
    public int EpvId { get; set; }

    public int EpvEprmid { get; set; }

    public int EpvEpsid { get; set; }

    public string? EpvValue { get; set; }

    public DateTime EpvTsinsert { get; set; }

    public DateTime EpvTsupdate { get; set; }

    public byte[] EpvRowVersion { get; set; } = null!;

    public bool EpvIsValueChanged { get; set; }

    public virtual EtlParameter EpvEprm { get; set; } = null!;

    public virtual EtlParameterSet EpvEps { get; set; } = null!;
}
