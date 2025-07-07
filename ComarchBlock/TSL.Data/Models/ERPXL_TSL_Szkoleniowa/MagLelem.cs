using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MagLelem
{
    public short? MaLMaEtyp { get; set; }

    public int MaLMaEnumer { get; set; }

    public short MaLMaElp { get; set; }

    public int MaLPobid { get; set; }

    public virtual ProdObiekty MaLPob { get; set; } = null!;

    public virtual MagElem MagElem { get; set; } = null!;
}
