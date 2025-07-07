using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AnalizyBiparam
{
    public string AbpNazwa { get; set; } = null!;

    public int? AbpParam { get; set; }

    public string? AbpData { get; set; }

    public byte[] AbpTimestamp { get; set; } = null!;
}
