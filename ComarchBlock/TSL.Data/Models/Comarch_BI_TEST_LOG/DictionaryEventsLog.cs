using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class DictionaryEventsLog
{
    public int LogId { get; set; }

    public DateTime Date { get; set; }

    public int UserId { get; set; }

    public int OperationType { get; set; }

    public string TableName { get; set; } = null!;

    public long PrimaryKey { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }
}
