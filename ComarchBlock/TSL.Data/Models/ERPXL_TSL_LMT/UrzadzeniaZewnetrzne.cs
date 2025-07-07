using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class UrzadzeniaZewnetrzne
{
    public int UzId { get; set; }

    public int? UzRodzaj { get; set; }

    public int? UzLp { get; set; }

    public string? UzKod { get; set; }

    public string? UzNazwa { get; set; }

    public string? UzOpis { get; set; }

    public string? UzUrzIdent { get; set; }

    public virtual ICollection<UrzadzeniaZewnetrzneObiekty> UrzadzeniaZewnetrzneObiekties { get; set; } = new List<UrzadzeniaZewnetrzneObiekty>();
}
