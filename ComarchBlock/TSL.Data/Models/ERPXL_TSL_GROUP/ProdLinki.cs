using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdLinki
{
    public int PlkId { get; set; }

    public int? PlkPzeid { get; set; }

    public short? PlkObiTyp { get; set; }

    public int? PlkObiNumer { get; set; }

    public decimal? PlkIlosc { get; set; }

    public virtual ProdZlecElem? PlkPze { get; set; }
}
