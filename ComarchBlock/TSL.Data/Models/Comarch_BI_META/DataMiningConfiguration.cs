using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class DataMiningConfiguration
{
    public int DmcId { get; set; }

    public string DmcName { get; set; } = null!;

    public string? DmcDescription { get; set; }

    public int DmcDmmid { get; set; }

    public bool DmcIsActive { get; set; }

    public virtual ICollection<DataMiningParameter> DataMiningParameters { get; set; } = new List<DataMiningParameter>();

    public virtual DataMiningModel DmcDmm { get; set; } = null!;
}
