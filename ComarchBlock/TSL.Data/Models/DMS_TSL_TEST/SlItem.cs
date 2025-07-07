using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class SlItem
{
    public int Id { get; set; }

    public bool? Extraction { get; set; }

    public decimal? VatRate { get; set; }

    public string? VatLabel { get; set; }

    public decimal? Netto { get; set; }

    public decimal? Vat { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public string? Registry { get; set; }

    public int? DocumentId { get; set; }

    public virtual SlDocument? Document { get; set; }
}
