using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AnKolejka
{
    public short AnKAnRtyp { get; set; }

    public int? AnKAnRfirma { get; set; }

    public int AnKAnRnumer { get; set; }

    public short? AnKAnRlp { get; set; }

    public byte? AnKStatus { get; set; }

    public short? AnKPriorytet { get; set; }

    public int? AnKKiedyDodany { get; set; }

    public short? AnKStrefa { get; set; }

    public virtual AnRaporty AnKAnRnumerNavigation { get; set; } = null!;
}
