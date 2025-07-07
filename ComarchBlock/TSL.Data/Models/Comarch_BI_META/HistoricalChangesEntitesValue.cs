using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class HistoricalChangesEntitesValue
{
    public long HcevId { get; set; }

    public string? HcevPropertyName { get; set; }

    public string? HcevOldValue { get; set; }

    public string? HcevNewValue { get; set; }

    public string? HcevDescription { get; set; }

    public long? HcevHsceid { get; set; }

    public virtual HistoricalChangesEntity? HcevHsce { get; set; }
}
