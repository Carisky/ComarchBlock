using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class CfgDzialy
{
    public int CdzCdzId { get; set; }

    public int CdzNumer { get; set; }

    public string CdzNazwa { get; set; } = null!;

    public decimal CdzStawka { get; set; }

    public short CdzFlaga { get; set; }

    public decimal CdzZrodlowa { get; set; }
}
