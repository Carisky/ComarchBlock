using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProgiTwrPromocje
{
    public int PtpPrpid { get; set; }

    public int PtpTprid { get; set; }

    public decimal? PtpWartosc { get; set; }

    public byte? PtpRodzaj { get; set; }

    public decimal? PtpWartoscProg { get; set; }

    public int? PtpMinIloscPoz { get; set; }

    public string? PtpGuid { get; set; }

    public virtual ProgiPromocje PtpPrp { get; set; } = null!;
}
