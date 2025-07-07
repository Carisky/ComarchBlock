using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class FrsZamienniki
{
    public int FrzId { get; set; }

    public int? FrzFrsId { get; set; }

    public int? FrzTwPid { get; set; }

    public virtual FrmStruktura? FrzFrs { get; set; }

    public virtual TwrPodm? FrzTwP { get; set; }
}
