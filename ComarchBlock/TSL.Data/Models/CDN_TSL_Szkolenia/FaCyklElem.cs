using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class FaCyklElem
{
    public int FceFcEid { get; set; }

    public int FceFcNid { get; set; }

    public byte? FceTypNb { get; set; }

    public int FceLp { get; set; }

    public int? FceTwrId { get; set; }

    public string FceKod { get; set; } = null!;

    public string FceNazwa { get; set; } = null!;

    public int? FceMagId { get; set; }

    public byte? FceIloscTyp { get; set; }

    public decimal? FceIlosc { get; set; }

    public decimal? FceIloscJm { get; set; }

    public string? FceJm { get; set; }

    public string? FceJmz { get; set; }

    public decimal FceJmprzelicznikL { get; set; }

    public int FceJmprzelicznikM { get; set; }

    public byte? FceCenaTyp { get; set; }

    public byte FceCenaZczteremaMiejscami { get; set; }

    public decimal? FceCena { get; set; }

    public decimal? FceCenaBrutto { get; set; }

    public string FceWaluta { get; set; } = null!;

    public decimal FceCenaNettoPln { get; set; }

    public decimal FceCenaBruttoPln { get; set; }

    public short FceGrupaCenowa { get; set; }

    public int? FceCloneId { get; set; }

    public virtual ICollection<FaCyklTwrKnt> FaCyklTwrKnts { get; set; } = new List<FaCyklTwrKnt>();

    public virtual FaCyklNag FceFcN { get; set; } = null!;
}
