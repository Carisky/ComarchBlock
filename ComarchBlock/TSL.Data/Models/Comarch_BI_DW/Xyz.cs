using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class Xyz
{
    public int? MagazynId { get; set; }

    public int? ProduktId { get; set; }

    public decimal? Wspolczynnik { get; set; }

    public string FlagaXyz { get; set; } = null!;
}
