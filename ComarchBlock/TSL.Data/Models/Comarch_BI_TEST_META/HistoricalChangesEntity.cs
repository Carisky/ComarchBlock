using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class HistoricalChangesEntity
{
    public long HsceId { get; set; }

    public string HsceOperationType { get; set; } = null!;

    public string? HscePrimaryKey { get; set; }

    public string HsceEntityName { get; set; } = null!;

    public string? HsceBusinessKey { get; set; }

    public string? HsceDescription { get; set; }

    public long? HsceHiscid { get; set; }

    public virtual ICollection<HistoricalChangesEntitesValue> HistoricalChangesEntitesValues { get; set; } = new List<HistoricalChangesEntitesValue>();

    public virtual HistoricalChange? HsceHisc { get; set; }
}
