using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class Service
{
    public int SvcId { get; set; }

    public int? SvcTimeout { get; set; }

    public int? SvcCommandTimeout { get; set; }

    public int SvcConnectionRetryCount { get; set; }

    public int SvcConnectionRetryInterval { get; set; }

    public virtual ICollection<ServicesAddress> ServicesAddresses { get; set; } = new List<ServicesAddress>();
}
