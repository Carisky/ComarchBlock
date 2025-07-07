using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KonfProdGrupyElem
{
    public int KegKpgid { get; set; }

    public short KegTwGtyp { get; set; }

    public int? KegTwGfirma { get; set; }

    public int KegTwGnumer { get; set; }

    public short? KegTwGlp { get; set; }

    public short? KegLp { get; set; }

    public virtual KonfProdGrupy KegKpg { get; set; } = null!;
}
