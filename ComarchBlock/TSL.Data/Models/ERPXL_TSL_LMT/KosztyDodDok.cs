using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KosztyDodDok
{
    public short KddGidtyp { get; set; }

    public int? KddGidfirma { get; set; }

    public int KddGidnumer { get; set; }

    public short KddGidlp { get; set; }

    public short? KddObiTyp { get; set; }

    public int? KddObiFirma { get; set; }

    public int? KddObiNumer { get; set; }

    public short? KddObiLp { get; set; }

    public byte? KddObiDtdc { get; set; }

    public byte? KddObiDtwo { get; set; }

    public int? KddRodzaj { get; set; }

    public byte? KddMagazyn { get; set; }

    public byte? KddNaliczono { get; set; }

    public string? KddKod { get; set; }

    public string? KddNazwa { get; set; }

    public int? KddData { get; set; }

    public decimal? KddWartosc { get; set; }

    public string? KddWaluta { get; set; }

    public int KddId { get; set; }
}
