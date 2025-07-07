using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class XlSlowniki
{
    public int SyncId { get; set; }

    public int Id { get; set; }

    public int Ts { get; set; }

    public byte Akcja { get; set; }
}
