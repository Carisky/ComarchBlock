using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalRaporty
{
    public int DrapDrapId { get; set; }

    public int DrapDstaId { get; set; }

    public int DrapDsrapId { get; set; }

    public DateTime? DrapTsExport { get; set; }
}
