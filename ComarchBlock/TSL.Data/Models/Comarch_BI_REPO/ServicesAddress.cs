using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class ServicesAddress
{
    public int SvcaId { get; set; }

    public int SvcaServiceId { get; set; }

    public string SvcaHost { get; set; } = null!;

    public int SvcaPort { get; set; }

    public virtual Service SvcaService { get; set; } = null!;
}
