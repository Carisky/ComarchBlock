using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KontaListaWybrane
{
    public int KlwOpeNumer { get; set; }

    public string KlwKkskonto { get; set; } = null!;

    public string? KlwKkskontoOrd { get; set; }

    public int? KlwTs { get; set; }
}
