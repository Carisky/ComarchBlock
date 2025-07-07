using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class HistoricalChangesCollectionValue
{
    public long HcvcId { get; set; }

    public string HcvcOperationType { get; set; } = null!;

    public string? HcvcOwnerPrimaryKey { get; set; }

    public string HcvcOwnerEntityName { get; set; } = null!;

    public string? HcvcOwnerPropertyName { get; set; }

    public string? HcvcPropertyName { get; set; }

    public int? HcvcDiscriminator { get; set; }

    public string? HcvcIdentifier { get; set; }

    public string? HcvcIndex { get; set; }

    public string? HcvcOldValue { get; set; }

    public string? HcvcNewValue { get; set; }

    public long? HcvcHiscid { get; set; }

    public virtual HistoricalChange? HcvcHisc { get; set; }
}
