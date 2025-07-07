using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcDocumentItem
{
    public int OdiId { get; set; }

    public int OdiDocumentId { get; set; }

    public string? OdiName { get; set; }

    public string? OdiUnit { get; set; }

    public decimal? OdiCount { get; set; }

    public decimal? OdiNetUnitPrice { get; set; }

    public decimal? OdiGrossUnitPrice { get; set; }

    public decimal? OdiNetValue { get; set; }

    public decimal? OdiGrossValue { get; set; }

    public decimal? OdiVatRate { get; set; }

    public decimal? OdiVatAmount { get; set; }

    public string? OdiProductCode { get; set; }

    public string? OdiEan { get; set; }

    public byte? OdiVatStatus { get; set; }

    public virtual OcDocument OdiDocument { get; set; } = null!;
}
