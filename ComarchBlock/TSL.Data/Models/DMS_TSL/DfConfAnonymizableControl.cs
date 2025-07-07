using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfAnonymizableControl
{
    public int CasId { get; set; }

    public int CasDfhid { get; set; }

    public string CasControlName { get; set; } = null!;

    public string? CasColumnName { get; set; }

    public int CasDctid { get; set; }

    public bool CasArchival { get; set; }
}
