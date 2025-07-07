using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcDocumentVatRegistry
{
    public int OcvId { get; set; }

    public int OcvDocumentId { get; set; }

    public decimal? OcvNet { get; set; }

    public decimal? OcvVat { get; set; }

    public decimal? OcvVatRate { get; set; }

    public string? OcvVatStatus { get; set; }

    public string? OcvPurchaseType { get; set; }

    public string? OcvVatDeduction { get; set; }

    public decimal? OcvGross { get; set; }

    public virtual OcDocument OcvDocument { get; set; } = null!;
}
