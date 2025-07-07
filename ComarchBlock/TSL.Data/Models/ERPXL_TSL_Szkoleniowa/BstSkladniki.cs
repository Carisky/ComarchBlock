using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BstSkladniki
{
    public int BsKBsNid { get; set; }

    public short BsKRodzaj { get; set; }

    public byte? BsKUwzgledniajWbilansie { get; set; }

    public string? BsKOpis { get; set; }

    public string? BsKSql { get; set; }

    public string? BsKKod { get; set; }

    public short? BsKPozycja { get; set; }

    public byte? BsKWplywaNaSaldo { get; set; }

    public virtual BstNag BsKBsN { get; set; } = null!;
}
