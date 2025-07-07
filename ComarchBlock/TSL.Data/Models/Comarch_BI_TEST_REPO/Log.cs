using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class Log
{
    public int LogId { get; set; }

    public int LogUserId { get; set; }

    public int? LogObjectId { get; set; }

    public int LogEventType { get; set; }

    public string? LogEventData { get; set; }

    public DateTime LogEventDateTime { get; set; }
}
