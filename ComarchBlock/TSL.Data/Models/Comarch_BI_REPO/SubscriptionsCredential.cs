using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class SubscriptionsCredential
{
    public int ScrUserId { get; set; }

    public string ScrCipher { get; set; } = null!;

    public byte[] ScrVector { get; set; } = null!;

    public virtual User1 ScrUser { get; set; } = null!;
}
