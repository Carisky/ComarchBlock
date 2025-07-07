using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class TraSelemDost
{
    public int TsDTsDid { get; set; }

    public int TsDTrSid { get; set; }

    public int TsDTrEid { get; set; }

    public int TsDPdEid { get; set; }

    public int? TsDTrSidDost { get; set; }

    public int? TsDZwrId { get; set; }

    public string TsDNumerPelny { get; set; } = null!;

    public string TsDNumerObcy { get; set; } = null!;

    public DateTime TsDDataOpe { get; set; }

    public string TsDDostawca { get; set; } = null!;

    public decimal TsDIlosc { get; set; }

    public decimal TsDIloscDostepna { get; set; }

    public decimal TsDWartosc { get; set; }

    public int TsDSrCdid { get; set; }

    public int TsDCecha1DeAid { get; set; }

    public short TsDCecha1Format { get; set; }

    public string TsDCecha1Kod { get; set; } = null!;

    public string TsDCecha1Wartosc { get; set; } = null!;

    public int TsDCecha2DeAid { get; set; }

    public short TsDCecha2Format { get; set; }

    public string TsDCecha2Kod { get; set; } = null!;

    public string TsDCecha2Wartosc { get; set; } = null!;

    public int TsDCecha3DeAid { get; set; }

    public short TsDCecha3Format { get; set; }

    public string TsDCecha3Kod { get; set; } = null!;

    public string TsDCecha3Wartosc { get; set; } = null!;

    public int TsDCecha4DeAid { get; set; }

    public short TsDCecha4Format { get; set; }

    public string TsDCecha4Kod { get; set; } = null!;

    public string TsDCecha4Wartosc { get; set; } = null!;

    public int TsDCecha5DeAid { get; set; }

    public short TsDCecha5Format { get; set; }

    public string TsDCecha5Kod { get; set; } = null!;

    public string TsDCecha5Wartosc { get; set; } = null!;

    public int TsDCecha6DeAid { get; set; }

    public short TsDCecha6Format { get; set; }

    public string TsDCecha6Kod { get; set; } = null!;

    public string TsDCecha6Wartosc { get; set; } = null!;

    public int TsDCecha7DeAid { get; set; }

    public short TsDCecha7Format { get; set; }

    public string TsDCecha7Kod { get; set; } = null!;

    public string TsDCecha7Wartosc { get; set; } = null!;

    public int TsDCecha8DeAid { get; set; }

    public short TsDCecha8Format { get; set; }

    public string TsDCecha8Kod { get; set; } = null!;

    public string TsDCecha8Wartosc { get; set; } = null!;

    public int TsDCecha9DeAid { get; set; }

    public short TsDCecha9Format { get; set; }

    public string TsDCecha9Kod { get; set; } = null!;

    public string TsDCecha9Wartosc { get; set; } = null!;

    public int TsDCecha10DeAid { get; set; }

    public short TsDCecha10Format { get; set; }

    public string TsDCecha10Kod { get; set; } = null!;

    public string TsDCecha10Wartosc { get; set; } = null!;

    public virtual TraElem TsDTrE { get; set; } = null!;
}
