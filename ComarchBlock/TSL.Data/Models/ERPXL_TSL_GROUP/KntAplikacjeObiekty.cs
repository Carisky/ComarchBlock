using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KntAplikacjeObiekty
{
    public int KobId { get; set; }

    public int? KobKntNumer { get; set; }

    public short? KobKntTyp { get; set; }

    public short? KobObiTyp { get; set; }

    public int? KobObiFirma { get; set; }

    public int? KobObiNumer { get; set; }

    public short? KobObiLp { get; set; }

    public virtual KntAplikacje? KntAplikacje { get; set; }
}
