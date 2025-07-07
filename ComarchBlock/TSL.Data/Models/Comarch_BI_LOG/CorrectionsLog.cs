using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class CorrectionsLog
{
    public int ClgId { get; set; }

    public int ClgCorrectionId { get; set; }

    public int ClgFactTableId { get; set; }

    public string ClgUpdater { get; set; } = null!;

    public int ClgFieldId { get; set; }

    public string ClgFieldRole { get; set; } = null!;

    public string ClgFieldName { get; set; } = null!;

    public string? ClgOldValue { get; set; }

    public string? ClgNewValue { get; set; }

    public DateTime ClgModificationDate { get; set; }

    public DateTime ClgTsinsert { get; set; }
}
