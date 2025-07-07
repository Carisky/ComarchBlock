using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OpeDefKol
{
    public int OdkOpeId { get; set; }

    public short OdkOpeTyp { get; set; }

    public int OdkDefId { get; set; }

    public virtual DefinicjeKolumn OdkDef { get; set; } = null!;
}
