using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PozDeklPit
{
    public int PdpPdpId { get; set; }

    public string PdpKod { get; set; } = null!;

    public byte PdpRodzaj { get; set; }

    public int PdpPoziom { get; set; }

    public int PdpWybieralny { get; set; }

    public string PdpOpis { get; set; } = null!;

    public int PdpPit4 { get; set; }

    public int PdpPit11 { get; set; }

    public int PdpPit8a { get; set; }

    public int PdpPit8b { get; set; }

    public int PdpPit40 { get; set; }

    public int PdpIft1 { get; set; }

    public int PdpPit8c { get; set; }

    public byte PdpFiltr { get; set; }

    public int PdpPitr { get; set; }

    public string PdpZjeId { get; set; } = null!;

    public virtual ICollection<TypWyplatum> TypWyplata { get; set; } = new List<TypWyplatum>();
}
