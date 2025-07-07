using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DokRelacje
{
    public int DoRId { get; set; }

    public short DoRMstyp { get; set; }

    public int? DoRMsfirma { get; set; }

    public int DoRMsnumer { get; set; }

    public short? DoRMslp { get; set; }

    public virtual DokDefinicje DoR { get; set; } = null!;
}
