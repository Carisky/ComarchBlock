using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TrwaleOsobyOdpowiedzialne
{
    public int SrOoSrOoid { get; set; }

    public int SrOoSrTid { get; set; }

    public DateTime? SrOoDataOd { get; set; }

    public DateTime? SrOoDataDo { get; set; }

    public int? SrOoPrcId { get; set; }

    public string SrOoPrcImieNazwisko { get; set; } = null!;

    public virtual Trwale SrOoSrT { get; set; } = null!;
}
