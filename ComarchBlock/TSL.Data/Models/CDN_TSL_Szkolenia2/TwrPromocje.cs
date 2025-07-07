using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TwrPromocje
{
    public int TprId { get; set; }

    public int? TprPrmId { get; set; }

    public short? TprTwrTyp { get; set; }

    public int? TprTwrFirma { get; set; }

    public int? TprTwrNumer { get; set; }

    public short? TprTwrLp { get; set; }

    public short? TprTwgTyp { get; set; }

    public int? TprTwgFirma { get; set; }

    public int? TprTwgNumer { get; set; }

    public short? TprTwgLp { get; set; }

    public int? TprTyp { get; set; }

    public decimal? TprWartosc { get; set; }

    public decimal? TprProg { get; set; }

    public string? TprWaluta { get; set; }

    public string? TprFlagaNb { get; set; }

    public string? TprNotatki { get; set; }

    public int? TprZstId { get; set; }

    public int? TprLp { get; set; }

    public int? TprRodzajCeny { get; set; }

    public virtual PrmKarty? TprPrm { get; set; }
}
