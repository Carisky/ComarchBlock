using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdProcesy
{
    public int PpcId { get; set; }

    public int? PpcZlecenie { get; set; }

    public int? PpcTechnologia { get; set; }

    public decimal? PpcIlosc { get; set; }

    public int? PpcOddzial { get; set; }

    public byte? PpcPriorytetRez { get; set; }

    public string? PpcNumerSeryjny { get; set; }

    public string? PpcOpis { get; set; }

    public decimal? PpcKoszt { get; set; }

    public byte? PpcPriorytetZlc { get; set; }

    public int? PpcPlanowacOd { get; set; }

    public decimal? PpcZrownoleglacDo { get; set; }

    public int? PpcPzeId { get; set; }

    public int? PpcPzepartia { get; set; }

    public int? PpcMagNumer { get; set; }

    public virtual ProdZlecenium? PpcZlecenieNavigation { get; set; }
}
