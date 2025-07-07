using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCfattachmentArchiveDocumentTypeSetting
{
    public int DaaId { get; set; }

    public int DaaDkoid { get; set; }

    public string DaaDocumentTypeId { get; set; } = null!;

    public string? DaaDocumentTypeName { get; set; }

    public int? DaaDdsmappingStageId { get; set; }

    public bool DaaIsDefault { get; set; }

    public bool DaaArchival { get; set; }
}
