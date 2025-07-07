using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DokNagEtapyHistorium
{
    public int DnEhDnEhid { get; set; }

    public int DnEhDoNid { get; set; }

    public int DnEhTyp { get; set; }

    public string DnEhSymbolPrzed { get; set; } = null!;

    public string DnEhSymbolPo { get; set; } = null!;

    public int DnEhOpeId { get; set; }

    public string? DnEhOpeKod { get; set; }

    public DateTime DnEhDataZmiany { get; set; }

    public string? DnEhKomentarz { get; set; }

    public virtual DokNag DnEhDoN { get; set; } = null!;
}
