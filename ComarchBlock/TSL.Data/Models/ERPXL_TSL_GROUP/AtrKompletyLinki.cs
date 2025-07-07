using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class AtrKompletyLinki
{
    public int AklAkpId { get; set; }

    public int AklAtKid { get; set; }

    public short? AklLp { get; set; }

    public virtual AtrybutyKomplety AklAkp { get; set; } = null!;

    public virtual AtrybutyKlasy AklAtK { get; set; } = null!;
}
