using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TrasyElem
{
    public int TsEId { get; set; }

    public int? TsETsNid { get; set; }

    public int? TsECzasDojazdu { get; set; }

    public short? TsELp { get; set; }

    public short? TsEKntAtyp { get; set; }

    public int? TsEKntAnumer { get; set; }

    public string? TsEOpis { get; set; }

    public virtual TrasyNag? TsETsN { get; set; }
}
