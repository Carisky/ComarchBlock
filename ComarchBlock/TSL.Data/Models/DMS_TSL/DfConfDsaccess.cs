using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfDsaccess
{
    public int DsaDdsid { get; set; }

    public int? DsaDcdid { get; set; }

    /// <summary>
    /// 1-pracownik, 2-dział, 3-stanowisko
    /// </summary>
    public int DsaTypeAccess { get; set; }

    public bool DsaArchival { get; set; }

    public virtual DfConfOsdictionary? DsaDcd { get; set; }

    public virtual DfConfDsdictionary DsaDds { get; set; } = null!;
}
