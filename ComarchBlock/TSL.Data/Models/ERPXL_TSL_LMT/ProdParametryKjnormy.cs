using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdParametryKjnormy
{
    public int KjnId { get; set; }

    public string? KjnWartosc { get; set; }

    public byte? KjnZgodna { get; set; }

    public byte? KjnDomyslna { get; set; }

    public decimal? KjnZakresOd { get; set; }

    public decimal? KjnZakresDo { get; set; }

    public int? KjnPpkoid { get; set; }

    public virtual ProdParamKjnormyObiektow? KjnPpko { get; set; }
}
