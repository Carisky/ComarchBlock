using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class DietyRyczalty
{
    public int DiRDiRid { get; set; }

    public DateTime DiRData { get; set; }

    public byte DiRTyp { get; set; }

    public string DiRKraj { get; set; } = null!;

    public string DiRKodKraju { get; set; } = null!;

    public string DiRWaluta { get; set; } = null!;

    public decimal DiRDietaU { get; set; }

    public decimal DiRDietaI { get; set; }

    public decimal DiRRyczaltU { get; set; }

    public decimal DiRRyczaltI { get; set; }
}
