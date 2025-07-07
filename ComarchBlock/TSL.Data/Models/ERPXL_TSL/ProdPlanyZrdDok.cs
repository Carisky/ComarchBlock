using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdPlanyZrdDok
{
    public int PpzPppid { get; set; }

    public int PpzDokNumer { get; set; }

    public short PpzDokTyp { get; set; }

    public int PpzDokLp { get; set; }

    public decimal? PpzIlosc { get; set; }

    public virtual ProdPlanyProdukty PpzPpp { get; set; } = null!;
}
