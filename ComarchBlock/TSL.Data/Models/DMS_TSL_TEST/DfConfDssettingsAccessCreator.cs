using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfDssettingsAccessCreator
{
    public int DacDfhid { get; set; }

    public int DacDcdid { get; set; }

    public bool DacArchival { get; set; }

    public virtual DfHeadDokumentFlow DacDfh { get; set; } = null!;
}
