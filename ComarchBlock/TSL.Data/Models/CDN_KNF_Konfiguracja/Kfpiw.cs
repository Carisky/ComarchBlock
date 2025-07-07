using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Kfpiw
{
    public int KfpiwKfpiwid { get; set; }

    public string KfpiwKod { get; set; } = null!;

    public string KfpiwOpis { get; set; } = null!;

    public byte KfpiwTyp { get; set; }
}
