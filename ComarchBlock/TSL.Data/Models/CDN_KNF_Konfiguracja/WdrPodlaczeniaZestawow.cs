using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WdrPodlaczeniaZestawow
{
    public int WdPzProcId { get; set; }

    public int WdPzKontId { get; set; }

    public byte WdPzStandardowy { get; set; }

    public int WdPzWdZid { get; set; }

    public string? WdPzWarunek { get; set; }

    public int? WdPzLp { get; set; }

    public string? WdPzEdycja { get; set; }
}
