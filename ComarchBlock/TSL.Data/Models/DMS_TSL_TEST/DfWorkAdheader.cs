using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkAdheader
{
    public int AdhId { get; set; }

    public int AdhFinancialCategoryId { get; set; }

    public string AdhFinancialCategoryName { get; set; } = null!;

    public int AdhAnalyticalDateId { get; set; }

    public string AdhAnalyticalDateName { get; set; } = null!;

    public int? AdhDcdacceptedBy { get; set; }

    public DateTime? AdhAcceptedDate { get; set; }

    public bool AdhArchival { get; set; }

    public string? AdhName { get; set; }

    public int? AdhXldid { get; set; }

    public DateTime? AdhModificationDate { get; set; }

    public int? AdhDdsid { get; set; }

    public int? AdhDcdid { get; set; }

    public virtual ICollection<DfWorkAddimension> DfWorkAddimensions { get; set; } = new List<DfWorkAddimension>();
}
