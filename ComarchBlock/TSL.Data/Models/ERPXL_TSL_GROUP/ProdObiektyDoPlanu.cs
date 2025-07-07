using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdObiektyDoPlanu
{
    public int PoplId { get; set; }

    public int? PoplPzlid { get; set; }

    public int? PoplPobid { get; set; }

    public int? PoplPfuid { get; set; }

    public int? PoplPtcid { get; set; }

    public short? PoplPoblp { get; set; }

    public virtual ProdTechnologiaCzynnosci? PoplPtc { get; set; }

    public virtual ProdZlecenium? PoplPzl { get; set; }
}
