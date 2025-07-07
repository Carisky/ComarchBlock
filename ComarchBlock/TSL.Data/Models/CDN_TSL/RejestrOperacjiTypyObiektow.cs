using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RejestrOperacjiTypyObiektow
{
    public int RoptobTyp { get; set; }

    public int RoptobSubTyp { get; set; }

    public string RoptobNazwa { get; set; } = null!;

    public int RoptobJezyk { get; set; }
}
