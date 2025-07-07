using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PlanyElementySkladnikow
{
    public int PgsId { get; set; }

    public int? PgsPsoid { get; set; }

    public int? PgsPfuId { get; set; }

    public int? PgsPtoiteracja { get; set; }

    public int? PgsWartoscObciazenia { get; set; }

    public virtual PlanySkladnikiObciazenium? PgsPso { get; set; }

    public virtual ICollection<PlanyElementyProdukty> PlanyElementyProdukties { get; set; } = new List<PlanyElementyProdukty>();
}
