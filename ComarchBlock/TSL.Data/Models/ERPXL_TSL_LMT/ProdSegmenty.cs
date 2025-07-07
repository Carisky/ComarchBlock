using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdSegmenty
{
    public int PsgId { get; set; }

    public string? PsgNazwa { get; set; }

    public string? PsgOpis { get; set; }

    public byte? PsgPredefiniowany { get; set; }
}
