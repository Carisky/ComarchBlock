using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsPartialPayment
{
    public int KsrId { get; set; }

    public int KsrDocumentId { get; set; }

    public decimal? KsrKwotaZaplatyCzesciowej { get; set; }

    public DateTime? KsrDataZaplatyCzesciowej { get; set; }

    public virtual KsDocument KsrDocument { get; set; } = null!;
}
