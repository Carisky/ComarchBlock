using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdPkjza
{
    public int PkjzId { get; set; }

    public int? PkjzPkjnid { get; set; }

    public int? PkjzPzaid { get; set; }

    public virtual ProdPkjnag? PkjzPkjn { get; set; }

    public virtual ProdZasoby? PkjzPza { get; set; }
}
