using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class TwrParMag
{
    public int TpmId { get; set; }

    public short? TpmTwrTyp { get; set; }

    public int? TpmTwrFirma { get; set; }

    public int? TpmTwrNumer { get; set; }

    public short? TpmTwrLp { get; set; }

    public short? TpmMagTyp { get; set; }

    public int? TpmMagFirma { get; set; }

    public int? TpmMagNumer { get; set; }

    public short? TpmMagLp { get; set; }

    public string? TpmPolozenie { get; set; }

    public decimal? TpmIloscZam { get; set; }

    public decimal? TpmIloscMin { get; set; }

    public decimal? TpmIloscMax { get; set; }

    public int? TpmMgAid { get; set; }

    public string? TpmKategoriaAbcxyz { get; set; }

    public int? TpmRodzajId { get; set; }

    public short? TpmOpeTypZ { get; set; }

    public int? TpmOpeFirmaZ { get; set; }

    public int? TpmOpeNumerZ { get; set; }

    public short? TpmOpeLpZ { get; set; }

    public int? TpmTstampZ { get; set; }

    public short? TpmOpeTypM { get; set; }

    public int? TpmOpeFirmaM { get; set; }

    public int? TpmOpeNumerM { get; set; }

    public short? TpmOpeLpM { get; set; }

    public int? TpmTstampM { get; set; }

    public decimal? TpmMrpEoq { get; set; }

    public virtual TwrKarty? TpmTwrNumerNavigation { get; set; }

    public virtual ICollection<TwrParMagHist> TwrParMagHists { get; set; } = new List<TwrParMagHist>();
}
