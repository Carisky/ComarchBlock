using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkAdheaderHistory
{
    public int AdjId { get; set; }

    public int AdjAdhid { get; set; }

    public int AdjFinancialCategoryId { get; set; }

    public string AdjFinancialCategoryName { get; set; } = null!;

    public int AdjAnalyticalDateId { get; set; }

    public string AdjAnalyticalDateName { get; set; } = null!;

    public int? AdjDcdacceptedBy { get; set; }

    public DateTime? AdjAcceptedDate { get; set; }

    public bool AdjArchival { get; set; }

    public string? AdjName { get; set; }

    public int? AdjXldid { get; set; }

    public DateTime? AdjModificationDate { get; set; }

    public int? AdjDdsid { get; set; }

    public int? AdjDcdid { get; set; }
}
