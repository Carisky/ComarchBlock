using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleZapisyHist
{
    public int SrZhSrZhid { get; set; }

    public int SrZhSrTid { get; set; }

    public DateTime? SrZhDataOd { get; set; }

    public DateTime? SrZhDataDo { get; set; }

    public string SrZhKrst { get; set; } = null!;

    public decimal SrZhStawka { get; set; }

    public decimal SrZhStawkaBil { get; set; }

    public byte SrZhJpkCzestotliwoscOdpisu { get; set; }

    public virtual Trwale SrZhSrT { get; set; } = null!;
}
