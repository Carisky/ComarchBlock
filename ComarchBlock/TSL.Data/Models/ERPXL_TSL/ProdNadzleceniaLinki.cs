using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdNadzleceniaLinki
{
    public int PnlId { get; set; }

    public int? PnlPzlid { get; set; }

    public int? PnlPnzid { get; set; }

    public virtual ProdNadzlecenium? PnlPnz { get; set; }

    public virtual ProdZlecenium? PnlPzl { get; set; }
}
