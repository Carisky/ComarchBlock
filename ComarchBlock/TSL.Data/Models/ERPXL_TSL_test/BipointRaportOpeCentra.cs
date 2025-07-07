using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class BipointRaportOpeCentra
{
    public int BroId { get; set; }

    public int? BroBrdid { get; set; }

    public int? BroNumer { get; set; }

    public short? BroTyp { get; set; }

    public virtual BipointRaportDef? BroBrd { get; set; }
}
