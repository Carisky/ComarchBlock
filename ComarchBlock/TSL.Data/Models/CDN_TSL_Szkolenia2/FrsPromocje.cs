using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class FrsPromocje
{
    public int FprId { get; set; }

    public int? FprPrmId { get; set; }

    public int? FprFrsId { get; set; }

    public virtual PrmKarty? FprPrm { get; set; }
}
