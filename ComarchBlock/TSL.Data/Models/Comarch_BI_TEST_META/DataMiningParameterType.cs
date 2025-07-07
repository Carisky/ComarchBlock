using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DataMiningParameterType
{
    public string DmptId { get; set; } = null!;

    public string DmptName { get; set; } = null!;

    public virtual ICollection<DataMiningParameter> DataMiningParameters { get; set; } = new List<DataMiningParameter>();
}
