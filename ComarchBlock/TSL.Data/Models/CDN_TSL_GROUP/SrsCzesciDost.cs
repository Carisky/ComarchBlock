using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SrsCzesciDost
{
    public int SrCdSrCdid { get; set; }

    public int SrCdTrSid { get; set; }

    public int SrCdSrCid { get; set; }

    public int? SrCdTrSidDost { get; set; }

    public int? SrCdZwrId { get; set; }

    public string SrCdNumerPelny { get; set; } = null!;

    public string SrCdNumerObcy { get; set; } = null!;

    public DateTime SrCdDataOpe { get; set; }

    public string SrCdDostawca { get; set; } = null!;

    public decimal SrCdIlosc { get; set; }

    public decimal SrCdIloscDostepna { get; set; }

    public decimal SrCdIloscWykorzystana { get; set; }

    public decimal SrCdWartosc { get; set; }

    public int SrCdCecha1DeAid { get; set; }

    public short SrCdCecha1Format { get; set; }

    public string SrCdCecha1Kod { get; set; } = null!;

    public string SrCdCecha1Wartosc { get; set; } = null!;

    public int SrCdCecha2DeAid { get; set; }

    public short SrCdCecha2Format { get; set; }

    public string SrCdCecha2Kod { get; set; } = null!;

    public string SrCdCecha2Wartosc { get; set; } = null!;

    public int SrCdCecha3DeAid { get; set; }

    public short SrCdCecha3Format { get; set; }

    public string SrCdCecha3Kod { get; set; } = null!;

    public string SrCdCecha3Wartosc { get; set; } = null!;

    public int SrCdCecha4DeAid { get; set; }

    public short SrCdCecha4Format { get; set; }

    public string SrCdCecha4Kod { get; set; } = null!;

    public string SrCdCecha4Wartosc { get; set; } = null!;

    public int SrCdCecha5DeAid { get; set; }

    public short SrCdCecha5Format { get; set; }

    public string SrCdCecha5Kod { get; set; } = null!;

    public string SrCdCecha5Wartosc { get; set; } = null!;

    public int SrCdCecha6DeAid { get; set; }

    public short SrCdCecha6Format { get; set; }

    public string SrCdCecha6Kod { get; set; } = null!;

    public string SrCdCecha6Wartosc { get; set; } = null!;

    public int SrCdCecha7DeAid { get; set; }

    public short SrCdCecha7Format { get; set; }

    public string SrCdCecha7Kod { get; set; } = null!;

    public string SrCdCecha7Wartosc { get; set; } = null!;

    public int SrCdCecha8DeAid { get; set; }

    public short SrCdCecha8Format { get; set; }

    public string SrCdCecha8Kod { get; set; } = null!;

    public string SrCdCecha8Wartosc { get; set; } = null!;

    public int SrCdCecha9DeAid { get; set; }

    public short SrCdCecha9Format { get; set; }

    public string SrCdCecha9Kod { get; set; } = null!;

    public string SrCdCecha9Wartosc { get; set; } = null!;

    public int SrCdCecha10DeAid { get; set; }

    public short SrCdCecha10Format { get; set; }

    public string SrCdCecha10Kod { get; set; } = null!;

    public string SrCdCecha10Wartosc { get; set; } = null!;

    public virtual SrsCzesci SrCdSrC { get; set; } = null!;
}
