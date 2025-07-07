using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class BstSkladnikiDef
{
    public int BsfId { get; set; }

    public string? BsfKod { get; set; }

    public string? BsfNazwa { get; set; }

    public string? BsfSql { get; set; }

    public string? BsfWarunek { get; set; }

    public byte? BsfWplywaNaSaldo { get; set; }
}
