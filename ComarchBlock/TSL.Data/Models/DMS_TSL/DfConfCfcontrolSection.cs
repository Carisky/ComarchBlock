using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfCfcontrolSection
{
    public int CfsId { get; set; }

    public string CfsName { get; set; } = null!;

    public int CfsDshid { get; set; }

    public bool CfsIsStaticColumnCountMode { get; set; }

    public int? CfsColumnCount { get; set; }

    public int? CfsControlsMaxWidth { get; set; }

    public int? CfsPosition { get; set; }

    public bool CfsArchival { get; set; }

    public int? CfsCfcid { get; set; }

    public virtual ICollection<DfConfCfcardDokFlow> DfConfCfcardDokFlows { get; set; } = new List<DfConfCfcardDokFlow>();
}
