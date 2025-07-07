using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfNotificationToken
{
    public int DntId { get; set; }

    public string DntToken { get; set; } = null!;

    public int? DntDcdid { get; set; }

    public int? DntPlatform { get; set; }
}
