using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class DataMiningParameter
{
    public int DmpId { get; set; }

    public int DmpDmcid { get; set; }

    public string DmpDatid { get; set; } = null!;

    public string DmpDmptid { get; set; } = null!;

    public string? DmpValue { get; set; }

    public string? DmpDefaultValue { get; set; }

    public string DmpName { get; set; } = null!;

    public string? DmpDecription { get; set; }

    public string? DmpFriendlyName { get; set; }

    public string? DmpOperator { get; set; }

    public virtual DataType DmpDat { get; set; } = null!;

    public virtual DataMiningConfiguration DmpDmc { get; set; } = null!;

    public virtual DataMiningParameterType DmpDmpt { get; set; } = null!;
}
