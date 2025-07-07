using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class RetroPlt
{
    public int RplId { get; set; }

    public int? RplRtKid { get; set; }

    public short? RplPltTyp { get; set; }

    public int? RplPltLp { get; set; }

    public int? RplTerminMaks { get; set; }

    public virtual RetroKarty? RplRtK { get; set; }
}
