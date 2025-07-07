using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KompElem
{
    public int KmeKmnid { get; set; }

    public short KmeKmelp { get; set; }

    public byte? KmeOdrzucona { get; set; }

    public short? KmeLp { get; set; }

    public short? KmeNalTyp { get; set; }

    public int? KmeNalFirma { get; set; }

    public int? KmeNalNumer { get; set; }

    public short? KmeNalLp { get; set; }

    public short? KmeZobTyp { get; set; }

    public int? KmeZobFirma { get; set; }

    public int? KmeZobNumer { get; set; }

    public short? KmeZobLp { get; set; }

    public decimal? KmeKwota { get; set; }

    public string? KmeWaluta { get; set; }

    public int? KmeDodOpeNumer { get; set; }

    public int? KmeStatOpeNumer { get; set; }

    public int? KmeStatData { get; set; }

    public virtual KompNag KmeKmn { get; set; } = null!;

    public virtual ICollection<KompElemPlatnosci> KompElemPlatnoscis { get; set; } = new List<KompElemPlatnosci>();
}
