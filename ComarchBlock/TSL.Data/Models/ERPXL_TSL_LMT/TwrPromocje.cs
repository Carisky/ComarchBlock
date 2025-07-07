using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

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

    public byte? TprWymagany { get; set; }

    public byte? TprLimitTyp { get; set; }

    public decimal? TprLimitWartosc { get; set; }

    public byte? TprProgTyp { get; set; }

    public decimal? TprProgWartosc { get; set; }

    public byte? TprLimitRodzaj { get; set; }

    public string? TprGuid { get; set; }

    public byte? TprAktywny { get; set; }

    public int? TprLastMod { get; set; }

    public string? TprOpeMod { get; set; }

    public virtual ICollection<RefPromocje> RefPromocjes { get; set; } = new List<RefPromocje>();

    public virtual PrmKarty? TprPrm { get; set; }

    public virtual ICollection<Dostawy> DprDstNumers { get; set; } = new List<Dostawy>();
}
