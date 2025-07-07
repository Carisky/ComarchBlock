using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PanstwaTrzecie
{
    public int PaTPaTid { get; set; }

    public int PaTRucid { get; set; }

    public string PaTKraj { get; set; } = null!;

    public string PaTUzasadnienie { get; set; } = null!;

    public string PaTSzczegoly { get; set; } = null!;

    public virtual RejestrCzynnosci PaTRuc { get; set; } = null!;
}
