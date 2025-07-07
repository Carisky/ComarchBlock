using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZrnplanyElem
{
    public short? ZpeGidtyp { get; set; }

    public int? ZpeGidfirma { get; set; }

    public int ZpeGidnumer { get; set; }

    public short ZpeGidlp { get; set; }

    public int? ZpeSsWid { get; set; }

    public int? ZpeDataPrzegladu { get; set; }

    public virtual ZrnplanyNag ZpeGidnumerNavigation { get; set; } = null!;
}
