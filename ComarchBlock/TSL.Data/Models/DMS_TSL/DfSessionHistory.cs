using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfSessionHistory
{
    public int ShId { get; set; }

    public string ShOperator { get; set; } = null!;

    public int ShOperatorId { get; set; }

    public Guid? ShGuid { get; set; }

    public DateTime ShLoginDate { get; set; }

    public DateTime? ShLogoutDate { get; set; }

    public int? ShWorkingTimeMinutes { get; set; }

    public int ShAppType { get; set; }

    public string? ShLpAddress { get; set; }
}
