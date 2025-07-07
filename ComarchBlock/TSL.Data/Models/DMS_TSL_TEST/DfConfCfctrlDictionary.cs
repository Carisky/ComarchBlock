using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCfctrlDictionary
{
    public int DdcId { get; set; }

    public int? DdcDkoid { get; set; }

    public string DdcName { get; set; } = null!;

    public bool DdcArchival { get; set; }

    public bool DdcIsDefault { get; set; }

    public int? DdcDmlid { get; set; }

    public virtual DfConfCfcardDokFlow? DdcDko { get; set; }
}
