using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KreatorKodowNag
{
    public int KrNId { get; set; }

    public string? KrNKod { get; set; }

    public string? KrNNazwa { get; set; }

    public string? KrNSeparator { get; set; }

    public byte? KrNAutonumerTyp { get; set; }

    public byte? KrNAutonumerIloscCyfr { get; set; }

    public int? KrNAutonumerPoczatkowy { get; set; }

    public string? KrNOpis { get; set; }

    public int? KrNCzasMod { get; set; }

    public int? KrNOpeMod { get; set; }

    public byte? KrNBrakSeparatora { get; set; }

    public virtual ICollection<KreatorKodowElem> KreatorKodowElems { get; set; } = new List<KreatorKodowElem>();
}
