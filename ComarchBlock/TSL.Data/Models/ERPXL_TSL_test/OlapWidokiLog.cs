using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OlapWidokiLog
{
    public int OwgId { get; set; }

    public int? OwgOwiid { get; set; }

    public int? OwgPrcNumer { get; set; }

    public int? OwgTstampUruchomienia { get; set; }

    public int? OwgCzasUruchamiania { get; set; }

    public short? OwgIkr { get; set; }
}
