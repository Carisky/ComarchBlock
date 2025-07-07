using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class SamplesLog
{
    public int SmplPmlid { get; set; }

    public float SmplValue { get; set; }

    public int SmplIndex { get; set; }

    public virtual ProcessMeasurementLog SmplPml { get; set; } = null!;
}
