using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class FrsPromocje
{
    public int FprId { get; set; }

    public int? FprPrmId { get; set; }

    public int? FprFrsId { get; set; }

    public virtual FrmStruktura? FprFrs { get; set; }

    public virtual PrmKarty? FprPrm { get; set; }
}
