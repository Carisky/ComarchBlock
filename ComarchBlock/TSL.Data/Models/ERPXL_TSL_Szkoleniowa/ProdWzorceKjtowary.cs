using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdWzorceKjtowary
{
    public int PwtId { get; set; }

    public int? PwtTwrGidnumer { get; set; }

    public short? PwtTwrGidtyp { get; set; }

    public int? PwtWkjid { get; set; }

    public byte? PwtDomyslny { get; set; }

    public virtual ProdWzorceKj? PwtWkj { get; set; }
}
