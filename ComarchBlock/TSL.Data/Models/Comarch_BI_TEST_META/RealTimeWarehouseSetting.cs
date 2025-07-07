using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_META;

public partial class RealTimeWarehouseSetting
{
    public int RwsId { get; set; }

    public string? RwsName { get; set; }

    public string? RwsCustomValue { get; set; }

    public DateTime? RwsTsinsert { get; set; }

    public DateTime? RwsTsupdate { get; set; }

    public byte[]? RwsRowVersion { get; set; }
}
