using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SystemInfo
{
    public int SysIId { get; set; }

    public byte SysITyp { get; set; }

    public string? SysIDane { get; set; }

    public byte SysIWyslane { get; set; }

    public string SysIBledy { get; set; } = null!;

    public int SysIData { get; set; }

    public string SysIAdresMac { get; set; } = null!;

    public byte SysIAutomat { get; set; }

    public byte[]? SysIPlikDl { get; set; }
}
