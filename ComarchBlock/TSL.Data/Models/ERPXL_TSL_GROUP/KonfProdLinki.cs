using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KonfProdLinki
{
    public int KplKpgid { get; set; }

    public int KplPteid { get; set; }

    public short? KplPtetyp { get; set; }

    public virtual KonfProdGrupy KplKpg { get; set; } = null!;
}
