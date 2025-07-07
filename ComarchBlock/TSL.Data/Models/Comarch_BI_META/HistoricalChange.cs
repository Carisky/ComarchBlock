using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class HistoricalChange
{
    public long HiscId { get; set; }

    public string? HiscUser { get; set; }

    public DateTime HiscTsinsert { get; set; }

    public string? HiscDescription { get; set; }

    public byte[]? HiscEntityPaths { get; set; }

    public virtual ICollection<HistoricalChangesCollectionValue> HistoricalChangesCollectionValues { get; set; } = new List<HistoricalChangesCollectionValue>();

    public virtual ICollection<HistoricalChangesEntity> HistoricalChangesEntities { get; set; } = new List<HistoricalChangesEntity>();
}
