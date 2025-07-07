using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class OcDocumentJpkcode
{
    public int OdjId { get; set; }

    public int OdjDocumentId { get; set; }

    public string? OdjCode { get; set; }

    public virtual OcDocument OdjDocument { get; set; } = null!;
}
