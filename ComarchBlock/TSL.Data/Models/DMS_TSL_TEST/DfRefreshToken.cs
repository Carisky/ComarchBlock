using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfRefreshToken
{
    public int RftId { get; set; }

    public int RftDcdid { get; set; }

    public int RftAppid { get; set; }

    public string RftToken { get; set; } = null!;

    public DateTime RftExpires { get; set; }

    public DateTime RftCreated { get; set; }

    public string? RftCreatedByIp { get; set; }

    public DateTime? RftRevoked { get; set; }

    public string? RftRevokedByIp { get; set; }

    public string? RftReplacedByToken { get; set; }

    public virtual DfApplication RftApp { get; set; } = null!;

    public virtual DfConfOsdictionary RftDcd { get; set; } = null!;
}
