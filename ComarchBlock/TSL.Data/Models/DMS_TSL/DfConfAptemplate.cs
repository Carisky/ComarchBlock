using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfAptemplate
{
    public int AptId { get; set; }

    public string AptName { get; set; } = null!;

    public string AptVersion { get; set; } = null!;

    public string AptContent { get; set; } = null!;

    public bool AptIsPredefined { get; set; }

    public bool AptIsLite { get; set; }

    public bool AptArchival { get; set; }
}
