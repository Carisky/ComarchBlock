using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCfattachmentArchiveDocumentTypeSettingsMapping
{
    public int DamId { get; set; }

    public int DamDaaid { get; set; }

    public string DamAttributeId { get; set; } = null!;

    public string DamAttributeName { get; set; } = null!;

    public int DamAttributeType { get; set; }

    public string DamDkoid { get; set; } = null!;

    public int DamAttributeIsRequired { get; set; }

    public bool DamArchival { get; set; }
}
