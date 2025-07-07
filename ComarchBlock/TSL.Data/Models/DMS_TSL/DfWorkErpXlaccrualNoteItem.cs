using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfWorkErpXlaccrualNoteItem
{
    public int XlnId { get; set; }

    public int? XlnPosition { get; set; }

    public int XlnXldid { get; set; }

    public decimal? XlnIncome { get; set; }

    public decimal? XlnExpenditure { get; set; }

    public string? XlnDescription { get; set; }

    public string XlnSymbolId { get; set; } = null!;

    public bool XlnArchival { get; set; }

    public DateTime? XlnModificationDate { get; set; }

    public int? XlnDdsid { get; set; }

    public int? XlnDcdid { get; set; }

    public virtual DfWorkErpXldocument XlnXld { get; set; } = null!;
}
