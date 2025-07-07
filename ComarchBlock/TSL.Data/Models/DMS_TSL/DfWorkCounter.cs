using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkCounter
{
    public int DwtDfhid { get; set; }

    public short DwtYear { get; set; }

    public byte DwtMonth { get; set; }

    public int DwtNumber { get; set; }
}
