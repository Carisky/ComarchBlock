using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagStruktura
{
    public int MgSMgOid { get; set; }

    public string MgSSegment { get; set; } = null!;

    public decimal? MgSX { get; set; }

    public decimal? MgSY { get; set; }

    public short? MgSOrientacja { get; set; }

    public byte? MgSStronaDostepu { get; set; }
}
