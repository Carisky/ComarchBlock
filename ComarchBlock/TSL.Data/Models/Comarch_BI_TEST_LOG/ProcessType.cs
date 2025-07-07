using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class ProcessType
{
    public string ProtId { get; set; } = null!;

    public string ProtName { get; set; } = null!;

    public virtual ICollection<LogActionGroup> LogActionGroups { get; set; } = new List<LogActionGroup>();

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
}
