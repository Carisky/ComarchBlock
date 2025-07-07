using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WdrPodlaczeniaWydrukow
{
    public byte WdPwStandardowy { get; set; }

    public int WdPwWdZid { get; set; }

    public int WdPwWdrId { get; set; }

    public string? WdPwWarunek { get; set; }

    public int? WdPwLp { get; set; }

    public string? WdPwEdycja { get; set; }
}
