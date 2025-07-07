using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrtSezon
{
    public short? SezGidtyp { get; set; }

    public int? SezGidfirma { get; set; }

    public int SezGidnumer { get; set; }

    public short? SezGidlp { get; set; }

    public short SezRok { get; set; }

    public short SezMiesiac { get; set; }

    public virtual SrtKarty SezGidnumerNavigation { get; set; } = null!;
}
