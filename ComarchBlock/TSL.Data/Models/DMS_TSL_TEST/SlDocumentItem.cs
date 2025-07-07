using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlDocumentItem
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public decimal? Amount { get; set; }

    public string? Unit { get; set; }

    public string? VatLabel { get; set; }

    public decimal? VatRate { get; set; }

    public decimal? UnitValue { get; set; }

    public decimal? Netto { get; set; }

    public decimal? Vat { get; set; }

    public decimal? Gross { get; set; }

    public int? DocumentId { get; set; }

    public virtual SlDocument? Document { get; set; }
}
