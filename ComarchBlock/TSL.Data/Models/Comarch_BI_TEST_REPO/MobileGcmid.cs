using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class MobileGcmid
{
    public int MgiAccountId { get; set; }

    public string MgiGcmid { get; set; } = null!;

    public virtual MobileAccount MgiAccount { get; set; } = null!;
}
