using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfApplication
{
    public int AppId { get; set; }

    public string AppName { get; set; } = null!;

    public Guid AppGuid { get; set; }

    public bool AppArchival { get; set; }

    public virtual ICollection<DfApiKey> DfApiKeys { get; set; } = new List<DfApiKey>();

    public virtual ICollection<DfOneTimeToken> DfOneTimeTokens { get; set; } = new List<DfOneTimeToken>();

    public virtual ICollection<DfRefreshToken> DfRefreshTokens { get; set; } = new List<DfRefreshToken>();
}
