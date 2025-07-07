using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class MaNopisy
{
    public short? MnOMaNtyp { get; set; }

    public int? MnOMaNfirma { get; set; }

    public int MnOMaNnumer { get; set; }

    public short MnOMaNlp { get; set; }

    public byte? MnOTyp { get; set; }

    public string? MnOOpis { get; set; }

    public virtual MagNag MnOMaNnumerNavigation { get; set; } = null!;
}
