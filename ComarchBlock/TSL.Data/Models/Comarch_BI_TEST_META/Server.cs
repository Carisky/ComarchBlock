using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class Server
{
    public int SrvId { get; set; }

    public string? SrvInstanceName { get; set; }

    public string? SrvPublicIp { get; set; }

    public string SrvPrivateIp { get; set; } = null!;

    public virtual ICollection<DatabaseName> DatabaseNames { get; set; } = new List<DatabaseName>();
}
