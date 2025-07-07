using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdKosztyElem
{
    public int PkePkoid { get; set; }

    public short PkeObiTyp { get; set; }

    public int PkeObiNumer { get; set; }

    public decimal? PkeKwota { get; set; }

    public virtual ProdKoszty PkePko { get; set; } = null!;
}
