using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class CubeTableRange
{
    public int Srcgid { get; set; }

    public string TableName { get; set; } = null!;

    public string CurrentRange { get; set; } = null!;

    public bool IsChanged { get; set; }

    public bool IsGenerated { get; set; }
}
