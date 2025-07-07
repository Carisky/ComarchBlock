using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DataType
{
    public string DatId { get; set; } = null!;

    public string DatName { get; set; } = null!;

    public virtual ICollection<DataMiningParameter> DataMiningParameters { get; set; } = new List<DataMiningParameter>();

    public virtual ICollection<Field> Fields { get; set; } = new List<Field>();
}
