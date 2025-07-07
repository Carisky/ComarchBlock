using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class Level
{
    public int LvlId { get; set; }

    public string LvlName { get; set; } = null!;

    public virtual ICollection<LogAction> LogActions { get; set; } = new List<LogAction>();

    public virtual ICollection<ProcessEvent> ProcessEvents { get; set; } = new List<ProcessEvent>();
}
