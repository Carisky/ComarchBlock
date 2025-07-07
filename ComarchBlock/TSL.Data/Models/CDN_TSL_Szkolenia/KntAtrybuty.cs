using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class KntAtrybuty
{
    public int KnAKnAid { get; set; }

    public int KnADeAid { get; set; }

    public short? KnAPodmiotTyp { get; set; }

    public int? KnAPodmiotId { get; set; }

    public string KnAWartoscTxt { get; set; } = null!;

    public byte KnACzyKopiowac { get; set; }

    public byte KnACzyKod { get; set; }

    public byte KnACzyPrzenosic { get; set; }

    public byte KnACzyDrukowac { get; set; }

    public byte KnACzyKopiowacDoVat { get; set; }

    public virtual DefAtrybuty KnADeA { get; set; } = null!;

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
