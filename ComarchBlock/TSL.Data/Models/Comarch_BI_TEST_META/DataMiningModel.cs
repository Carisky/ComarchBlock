using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DataMiningModel
{
    public int DmmId { get; set; }

    public string DmmName { get; set; } = null!;

    public string? DmmDescription { get; set; }

    public int DmmDmsid { get; set; }

    public string DmmAlgorithmName { get; set; } = null!;

    public virtual ICollection<DataMiningConfiguration> DataMiningConfigurations { get; set; } = new List<DataMiningConfiguration>();

    public virtual DataMiningStructure DmmDms { get; set; } = null!;
}
