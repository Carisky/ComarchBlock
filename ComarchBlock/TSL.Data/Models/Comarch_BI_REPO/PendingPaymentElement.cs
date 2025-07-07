using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class PendingPaymentElement
{
    public int PppId { get; set; }

    public int PppPendingPaymentId { get; set; }

    public double PppPrice { get; set; }

    public int PppQuantity { get; set; }

    public double PppDiscount { get; set; }

    public virtual PendingPayment PppPendingPayment { get; set; } = null!;
}
