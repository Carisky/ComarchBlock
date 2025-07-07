using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PaczkiPrzelewowAkceptacje
{
    public int PcPaPcPaid { get; set; }

    public int PcPaPcPnid { get; set; }

    public DateTime PcPaData { get; set; }

    public int PcPaOpeId { get; set; }

    public byte PcPaTypAkceptacji { get; set; }

    public string? PcPaDodatkowe { get; set; }

    public virtual PaczkiPrzelewowNag PcPaPcPn { get; set; } = null!;
}
