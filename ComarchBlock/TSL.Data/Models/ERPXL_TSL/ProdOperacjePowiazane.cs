using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ProdOperacjePowiazane
{
    public int PopId { get; set; }

    public int? PopPczId { get; set; }

    public int? PopPrzedPczId { get; set; }
}
