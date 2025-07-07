using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfWorkErpXlarticlesHistory
{
    public int XlhId { get; set; }

    public int XlhXlaid { get; set; }

    public int? XlhPosition { get; set; }

    public int XlhXldid { get; set; }

    public int? XlhArticleId { get; set; }

    public string? XlhArticleName { get; set; }

    public decimal? XlhQuantity { get; set; }

    public string? XlhUnitName { get; set; }

    public bool? XlhIsBaseUnit { get; set; }

    public decimal? XlhPrice { get; set; }

    public int? XlhTaxRateId { get; set; }

    public bool XlhArchival { get; set; }

    public string? XlhArticleCode { get; set; }

    public decimal? XlhCorrectionDocumentAmount { get; set; }

    public int? XlhDdsid { get; set; }

    public int? XlhDcdid { get; set; }

    public DateTime? XlhModificationDate { get; set; }
}
