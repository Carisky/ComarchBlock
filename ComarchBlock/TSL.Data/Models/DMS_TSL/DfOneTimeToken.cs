using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfOneTimeToken
{
    public int OttId { get; set; }

    public int OttDcdid { get; set; }

    public int OttAppid { get; set; }

    public string OttToken { get; set; } = null!;

    public string OttPath { get; set; } = null!;

    public DateTime OttExpires { get; set; }

    public DateTime OttCreated { get; set; }

    public string? OttCreatedByIp { get; set; }

    public DateTime? OttUsed { get; set; }

    public string? OttUsedByIp { get; set; }

    public virtual DfApplication OttApp { get; set; } = null!;

    public virtual DfConfOsdictionary OttDcd { get; set; } = null!;
}
