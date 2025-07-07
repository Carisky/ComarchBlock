using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfctrlType
{
    /// <summary>
    /// Primary key
    /// </summary>
    public int DctId { get; set; }

    public string? DctName { get; set; }

    public virtual ICollection<DfConfCfcardDokFlow> DfConfCfcardDokFlows { get; set; } = new List<DfConfCfcardDokFlow>();
}
