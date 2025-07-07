using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracKartyRcp
{
    public int PkrPkrId { get; set; }

    public int PkrPrcId { get; set; }

    public string PkrNumer { get; set; } = null!;

    public DateTime PkrOkresOd { get; set; }

    public DateTime PkrOkresDo { get; set; }

    public virtual PracKod PkrPrc { get; set; } = null!;
}
