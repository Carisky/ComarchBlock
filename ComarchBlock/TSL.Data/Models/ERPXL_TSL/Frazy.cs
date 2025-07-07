using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Frazy
{
    public string? FzyOryginal { get; set; }

    public int FzyId { get; set; }

    public virtual ICollection<FrazyTlumaczenium> FrazyTlumaczenia { get; set; } = new List<FrazyTlumaczenium>();
}
