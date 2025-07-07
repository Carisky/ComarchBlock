using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcDocumentBarcode
{
    public int OcbId { get; set; }

    public int OcbDocumentId { get; set; }

    public string? OcbBarcodeText { get; set; }

    public string? OcbBarcodeType { get; set; }

    public int OcbLp { get; set; }
}
