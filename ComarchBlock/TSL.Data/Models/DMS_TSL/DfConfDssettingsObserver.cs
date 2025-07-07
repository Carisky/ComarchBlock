using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfDssettingsObserver
{
    public int DsoDfhid { get; set; }

    public int DsoDcdid { get; set; }

    public bool DsoCanEditDocument { get; set; }

    public bool DsoArchival { get; set; }

    public virtual DfHeadDokumentFlow DsoDfh { get; set; } = null!;
}
