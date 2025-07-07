using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class ApiService
{
    public string ApsName { get; set; } = null!;

    public string ApsServerAddress { get; set; } = null!;

    public int ApsPort { get; set; }

    public string ApsServiceType { get; set; } = null!;

    public string ApsUser { get; set; } = null!;

    public DateTime ApsTsinsert { get; set; }

    public bool ApsIsDefault { get; set; }

    public int ApsId { get; set; }

    public string? ApsGuid { get; set; }

    public string? ApsFullAddress { get; set; }

    public string? ApsProtocol { get; set; }

    public int? ApsGrpcPort { get; set; }
}
