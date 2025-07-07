using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KadrStaSlowniki
{
    public int KssKstId { get; set; }

    public int KssSlwId { get; set; }

    public short KssSlwTyp { get; set; }

    public int KssZakresZnajomosci { get; set; }

    public int? KssStopienZnajomosci { get; set; }

    public virtual KadrStanowiska KssKst { get; set; } = null!;
}
