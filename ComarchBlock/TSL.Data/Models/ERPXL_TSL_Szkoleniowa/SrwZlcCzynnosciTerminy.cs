using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrwZlcCzynnosciTerminy
{
    public int SztId { get; set; }

    public int? SztSzcid { get; set; }

    public int? SztTerminOd { get; set; }

    public int? SztTerminDo { get; set; }

    public int? SztZewnetrznySys { get; set; }

    public int? SztZewnetrznyId { get; set; }

    public virtual SrwZlcCzynnosci? SztSzc { get; set; }
}
