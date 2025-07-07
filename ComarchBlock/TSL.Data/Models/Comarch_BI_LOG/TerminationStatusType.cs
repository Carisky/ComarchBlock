using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class TerminationStatusType
{
    public string TstId { get; set; } = null!;

    public string TstName { get; set; } = null!;

    public virtual ICollection<Process> Processes { get; set; } = new List<Process>();

    public virtual ICollection<Transformation> Transformations { get; set; } = new List<Transformation>();
}
