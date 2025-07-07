using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KontaZakazy
{
    public int AcZAcZid { get; set; }

    public int AcZAccId { get; set; }

    public int AcZOpeId { get; set; }

    public virtual Kontum AcZAcc { get; set; } = null!;
}
