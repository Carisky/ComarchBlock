using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PodzielnikPrac
{
    public short? PdpPdnTyp { get; set; }

    public int? PdpPdnFirma { get; set; }

    public int PdpPdnNumer { get; set; }

    public int? PdpPdnLp { get; set; }

    public short PdpPrcTyp { get; set; }

    public int? PdpPrcFirma { get; set; }

    public int PdpPrcNumer { get; set; }

    public short? PdpPrcLp { get; set; }

    public decimal? PdpIlosc { get; set; }

    public int? PdpLicznik { get; set; }

    public virtual PodzielnikNag PdpPdnNumerNavigation { get; set; } = null!;

    public virtual PrcKarty PdpPrcNumerNavigation { get; set; } = null!;
}
