using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdTechnologiaZasobyTwX
{
    public int PttPtzid { get; set; }

    public int PttTwXnumer { get; set; }

    public short PttTwXtyp { get; set; }

    public short? PttCchTyp { get; set; }

    public int? PttCchFirma { get; set; }

    public int? PttCchNumer { get; set; }

    public short? PttCchLp { get; set; }

    public string? PttCecha { get; set; }

    public byte? PttCechaWkonf { get; set; }

    public string? PttWarunekWystapienia { get; set; }

    public virtual ProdTechnologiaZasoby PttPtz { get; set; } = null!;
}
