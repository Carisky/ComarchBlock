using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class LogActionGroup
{
    public int LagId { get; set; }

    /// <summary>
    /// Action Group name
    /// </summary>
    public string LagName { get; set; } = null!;

    /// <summary>
    /// Foreign key to process type
    /// </summary>
    public string LabProcessType { get; set; } = null!;

    public virtual ProcessType LabProcessTypeNavigation { get; set; } = null!;

    public virtual ICollection<LogAction> LogActions { get; set; } = new List<LogAction>();
}
