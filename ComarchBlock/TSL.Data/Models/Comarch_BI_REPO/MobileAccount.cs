using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class MobileAccount
{
    public int MacId { get; set; }

    public int MacUserId { get; set; }

    public string MacAccount { get; set; } = null!;

    public virtual User1 MacUser { get; set; } = null!;

    public virtual ICollection<MobileGcmid> MobileGcmids { get; set; } = new List<MobileGcmid>();
}
