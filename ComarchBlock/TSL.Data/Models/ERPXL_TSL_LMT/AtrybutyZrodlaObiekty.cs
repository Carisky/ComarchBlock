using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class AtrybutyZrodlaObiekty
{
    public int AzoAtzid { get; set; }

    public int AzoAtogidtyp { get; set; }

    public short AzoAtoelement { get; set; }

    public virtual AtrybutyZrodla AzoAtz { get; set; } = null!;
}
