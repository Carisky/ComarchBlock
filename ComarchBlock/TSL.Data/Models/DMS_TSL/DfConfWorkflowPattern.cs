using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfWorkflowPattern
{
    public int CwpId { get; set; }

    public string CwpName { get; set; } = null!;

    public string? CwpDescription { get; set; }

    public string CwpVersion { get; set; } = null!;

    public string CwpFile { get; set; } = null!;

    public bool CwpIsPredefined { get; set; }

    public bool CwpIsLite { get; set; }

    public bool CwpArchival { get; set; }

    public int? CwpErpSystem { get; set; }

    public bool CwpCsScript { get; set; }
}
