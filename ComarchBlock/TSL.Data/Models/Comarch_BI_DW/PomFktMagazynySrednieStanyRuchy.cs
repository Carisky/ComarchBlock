using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class PomFktMagazynySrednieStanyRuchy
{
    public int MgrMagId { get; set; }

    public int MgrJmId { get; set; }

    public int? MgrCzmid { get; set; }

    public int MgrProdId { get; set; }

    public int MgrZrodgid { get; set; }

    public decimal? MgrMiloscKsRuchPodst { get; set; }

    public decimal? MgrMiloscMagRuch { get; set; }

    public decimal? MgrMkoszt { get; set; }
}
