using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RoExpiredDoc
{
    public int DwdId { get; set; }

    public string? DwdFullNumber { get; set; }

    public string DcdName1 { get; set; } = null!;

    public int? ExpirationMinutes { get; set; }

    public string? Expiration { get; set; }
}
