using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class SubscriptionsReportsParameter
{
    public int SrpSubscriptionsReportsId { get; set; }

    public string SrpParameterName { get; set; } = null!;

    public int SrpParameterType { get; set; }

    public string SrpParameterValue { get; set; } = null!;

    public string? SrpParameterLabel { get; set; }

    public string? SrpParameterExpression { get; set; }

    public string? SrpParameterUniqueId { get; set; }

    public virtual SubscriptionsReport SrpSubscriptionsReports { get; set; } = null!;
}
