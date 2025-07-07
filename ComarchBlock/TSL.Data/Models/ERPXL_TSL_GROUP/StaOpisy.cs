using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class StaOpisy
{
    public short? StOStaTyp { get; set; }

    public int? StOStaFirma { get; set; }

    public int StOStaNumer { get; set; }

    public short StOStaLp { get; set; }

    public byte? StOTyp { get; set; }

    public string? StOOpis { get; set; }

    public virtual StaKarty StOStaNumerNavigation { get; set; } = null!;
}
