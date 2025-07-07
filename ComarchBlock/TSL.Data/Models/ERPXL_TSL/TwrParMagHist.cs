using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrParMagHist
{
    public int TpmhId { get; set; }

    public int? TpmhTpmid { get; set; }

    public string? TpmhKategoriaAbcxyz { get; set; }

    public int? TpmhRodzajId { get; set; }

    public short? TpmhOpeTyp { get; set; }

    public int? TpmhOpeFirma { get; set; }

    public int? TpmhOpeNumer { get; set; }

    public short? TpmhOpeLp { get; set; }

    public int? TpmhTstamp { get; set; }

    public virtual TwrParMag? TpmhTpm { get; set; }
}
