using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class PendingPayment
{
    public int PpaId { get; set; }

    public int PpaComapnyId { get; set; }

    public int PpaPackageId { get; set; }

    public int? PpaNumberExtend { get; set; }

    public int PpaMonthTime { get; set; }

    public string PpaGuid { get; set; } = null!;

    public int PpaStatus { get; set; }

    public DateTime? PpaPurchaseDate { get; set; }

    public double? PpaPurchaseAmount { get; set; }

    public string? PpaDotPayOperationNumber { get; set; }

    public string PpaCurrency { get; set; } = null!;

    public virtual ICollection<PendingPaymentElement> PendingPaymentElements { get; set; } = new List<PendingPaymentElement>();
}
