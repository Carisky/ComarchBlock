using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class BstDokumenty
{
    public int BsDBsNid { get; set; }

    public int BsDDokTyp { get; set; }

    public int BsDDokNumer { get; set; }

    public virtual BstNag BsDBsN { get; set; } = null!;
}
