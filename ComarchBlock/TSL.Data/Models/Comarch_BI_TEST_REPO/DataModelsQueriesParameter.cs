using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class DataModelsQueriesParameter
{
    public int DmqpQueryId { get; set; }

    public string DmqpName { get; set; } = null!;

    public int DmqpType { get; set; }

    public string DmqpDefinition { get; set; } = null!;

    public int DmqpId { get; set; }

    public virtual DataModelsQuery DmqpQuery { get; set; } = null!;
}
