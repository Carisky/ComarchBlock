using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class RejOp
{
    public short KroKartyp { get; set; }

    public int? KroKarfirma { get; set; }

    public int KroKarnumer { get; set; }

    public short? KroKarlp { get; set; }

    public short KroKaotyp { get; set; }

    public int? KroKaofirma { get; set; }

    public int KroKaonumer { get; set; }

    public short KroKaolp { get; set; }

    public short? KroPozycja { get; set; }

    public int? KroNumerPoczatkowy { get; set; }

    public short? KroSposobNumeracji { get; set; }

    public virtual Rejestry KroKarnumerNavigation { get; set; } = null!;

    public virtual Operacje Operacje { get; set; } = null!;
}
