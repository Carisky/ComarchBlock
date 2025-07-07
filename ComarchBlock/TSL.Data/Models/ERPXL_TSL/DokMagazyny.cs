using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DokMagazyny
{
    public int DokmDokId { get; set; }

    public int DokmMagNumer { get; set; }

    public byte DokmRodzaj { get; set; }

    public virtual Magazyny DokmMagNumerNavigation { get; set; } = null!;
}
