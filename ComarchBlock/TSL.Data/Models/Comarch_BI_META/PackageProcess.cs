using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class PackageProcess
{
    public int PapPrcId { get; set; }

    public int PapPacId { get; set; }

    public virtual Package PapPac { get; set; } = null!;

    public virtual Process PapPrc { get; set; } = null!;
}
