using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class DataModelsQuery
{
    public int DmqId { get; set; }

    public int DmqModelId { get; set; }

    public string? DmqQuery { get; set; }

    public int DmqType { get; set; }

    public virtual ICollection<DataModelsQueriesParameter> DataModelsQueriesParameters { get; set; } = new List<DataModelsQueriesParameter>();

    public virtual DataModel DmqModel { get; set; } = null!;
}
