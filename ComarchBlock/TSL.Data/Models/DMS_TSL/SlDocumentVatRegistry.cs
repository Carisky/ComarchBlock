using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class SlDocumentVatRegistry
{
    public int Id { get; set; }

    public decimal? VatRate { get; set; }

    public string? VatLabel { get; set; }

    public decimal? Netto { get; set; }

    public decimal? Vat { get; set; }

    public int? DocumentId { get; set; }

    public virtual SlDocument? Document { get; set; }
}
