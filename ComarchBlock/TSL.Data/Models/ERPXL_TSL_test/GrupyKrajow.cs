using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class GrupyKrajow
{
    public int GkrId { get; set; }

    public string? GkrKod { get; set; }

    public string? GkrNazwa { get; set; }

    public byte? GkrPredefiniowany { get; set; }
}
