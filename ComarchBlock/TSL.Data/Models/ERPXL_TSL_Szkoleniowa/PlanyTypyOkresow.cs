using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlanyTypyOkresow
{
    public int PtoId { get; set; }

    public int? PtoTerminOd { get; set; }

    public int? PtoPowtarzacCo { get; set; }

    public int? PtoFrsId { get; set; }

    public byte? PtoJednostka { get; set; }
}
