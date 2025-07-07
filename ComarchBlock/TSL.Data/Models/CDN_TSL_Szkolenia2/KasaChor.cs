using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class KasaChor
{
    public int KchKchId { get; set; }

    public string KchKod { get; set; } = null!;

    public int KchPoziom { get; set; }

    public int KchWybieralny { get; set; }

    public string KchOpis { get; set; } = null!;

    public string KchZjeId { get; set; } = null!;
}
