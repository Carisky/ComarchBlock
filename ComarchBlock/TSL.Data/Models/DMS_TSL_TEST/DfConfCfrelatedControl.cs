using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class DfConfCfrelatedControl
{
    public int DrcId { get; set; }

    public int DrcDkoid { get; set; }

    public int DrcRelatedControlId { get; set; }

    public bool DrcArchival { get; set; }

    public virtual DfConfCfcardDokFlow DrcDko { get; set; } = null!;

    public virtual DfConfCfcardDokFlow DrcRelatedControl { get; set; } = null!;
}
