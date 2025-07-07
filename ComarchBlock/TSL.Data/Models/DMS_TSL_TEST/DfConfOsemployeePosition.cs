using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfOsemployeePosition
{
    public int DepDcdpositionId { get; set; }

    public int DepDcdemployeeId { get; set; }

    public bool DepArchival { get; set; }

    public virtual DfConfOsdictionary DepDcdemployee { get; set; } = null!;

    public virtual DfConfOsdictionary DepDcdposition { get; set; } = null!;
}
