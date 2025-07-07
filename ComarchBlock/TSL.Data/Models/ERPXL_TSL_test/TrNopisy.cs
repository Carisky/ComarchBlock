using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class TrNopisy
{
    public short? TnOTrnTyp { get; set; }

    public int? TnOTrnFirma { get; set; }

    public int TnOTrnNumer { get; set; }

    public short TnOTrnLp { get; set; }

    public byte? TnOTyp { get; set; }

    public string? TnOOpis { get; set; }

    public int? TnOOpisCharset { get; set; }

    public virtual TraNag TnOTrnNumerNavigation { get; set; } = null!;
}
