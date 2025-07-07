using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DanePlac
{
    public int DplDplId { get; set; }

    public int DplKod { get; set; }

    public byte DplRodzaj { get; set; }

    public int DplPoziom { get; set; }

    public int DplWybieralny { get; set; }

    public string DplOpis { get; set; } = null!;

    public string DplZjeId { get; set; } = null!;
}
