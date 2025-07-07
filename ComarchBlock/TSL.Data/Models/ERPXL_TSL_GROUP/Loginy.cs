using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Loginy
{
    public string LgnLogin { get; set; } = null!;

    public byte[] LgnHaslo { get; set; } = null!;

    public byte LgnTyp { get; set; }
}
