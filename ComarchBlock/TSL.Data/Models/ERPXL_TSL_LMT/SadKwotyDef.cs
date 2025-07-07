using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class SadKwotyDef
{
    public int SkdId { get; set; }

    public string? SkdNazwa { get; set; }

    public short? SkdVat { get; set; }

    public short? SkdClo { get; set; }

    public short? SkdAkcyza { get; set; }

    public short? SkdPomin { get; set; }

    public short? SkdWaluta { get; set; }

    public short? SkdPlatnosci { get; set; }

    public string? SkdKod { get; set; }
}
