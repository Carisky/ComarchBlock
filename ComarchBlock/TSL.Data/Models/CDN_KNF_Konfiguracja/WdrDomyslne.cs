using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class WdrDomyslne
{
    public int WdDProcId { get; set; }

    public int WdDKontId { get; set; }

    public int WdDOpeId { get; set; }

    public byte? WdDStandardowy { get; set; }

    public int? WdDWdZid { get; set; }

    public int? WdDWdrId { get; set; }

    public short WdDRodzaj { get; set; }
}
