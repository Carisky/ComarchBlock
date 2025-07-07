using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class KonfProdGrupyStruktura
{
    public int KgsId { get; set; }

    public int? KgsRodzicId { get; set; }

    public int? KgsKpgid { get; set; }

    public short? KgsTwrTyp { get; set; }

    public int? KgsTwrFirma { get; set; }

    public int? KgsTwrNumer { get; set; }

    public short? KgsTwrLp { get; set; }

    public virtual KonfProdGrupy? KgsKpg { get; set; }
}
