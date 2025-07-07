using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsSordocument
{
    public int KssId { get; set; }

    public int KssDocumentId { get; set; }

    public string? KssNumerWz { get; set; }

    public virtual KsDocument KssDocument { get; set; } = null!;
}
