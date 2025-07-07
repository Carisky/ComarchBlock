using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DokNagProcesEtapy
{
    public int DnPrDnPrId { get; set; }

    public int? DnPrDoNid { get; set; }

    public int? DnPrTyp { get; set; }

    public int DnPrLp { get; set; }

    public int DnPrPoprzedniLp { get; set; }

    public short DnPrPoziom { get; set; }

    public virtual DokNag? DnPrDoN { get; set; }

    public virtual ICollection<DokNagEtapy> DokNagEtapies { get; set; } = new List<DokNagEtapy>();
}
