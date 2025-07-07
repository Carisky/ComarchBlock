using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DataMiningStructure
{
    public int DmsId { get; set; }

    public string DmsName { get; set; } = null!;

    public string? DmsDescription { get; set; }

    public virtual ICollection<DataMiningModel> DataMiningModels { get; set; } = new List<DataMiningModel>();
}
