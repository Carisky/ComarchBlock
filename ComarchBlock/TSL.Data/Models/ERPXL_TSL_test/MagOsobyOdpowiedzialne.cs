using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class MagOsobyOdpowiedzialne
{
    public int MooId { get; set; }

    public int? MooMagNumer { get; set; }

    public int? MooPrcNumer { get; set; }

    public decimal? MooProcentOdpowiedzialnosci { get; set; }

    public int? MooDataOd { get; set; }

    public int? MooDataDo { get; set; }

    public virtual Magazyny? MooMagNumerNavigation { get; set; }
}
