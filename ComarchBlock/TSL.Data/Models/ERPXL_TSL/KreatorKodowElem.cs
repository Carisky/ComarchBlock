using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KreatorKodowElem
{
    public int KrEId { get; set; }

    public int? KrEKrnId { get; set; }

    public int? KrEPozycja { get; set; }

    public byte? KrEPobierzDoNazwy { get; set; }

    public short? KrEObiTyp { get; set; }

    public int? KrEObiFirma { get; set; }

    public int? KrEObiNumer { get; set; }

    public short? KrEObiLp { get; set; }

    public int? KrECzasMod { get; set; }

    public int? KrEOpeMod { get; set; }

    public virtual KreatorKodowNag? KrEKrn { get; set; }
}
