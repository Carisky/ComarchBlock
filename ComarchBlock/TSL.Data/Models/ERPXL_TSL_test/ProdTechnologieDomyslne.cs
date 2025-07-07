using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdTechnologieDomyslne
{
    public int PtdPteid { get; set; }

    public short PtdKntTyp { get; set; }

    public int PtdKntNumer { get; set; }

    public int? PtdKntDtyp { get; set; }

    public int? PtdKntDnumer { get; set; }

    public int PtdPtzId { get; set; }

    public int? PtdDomyslna { get; set; }

    public virtual ProdTechnologium PtdPte { get; set; } = null!;
}
