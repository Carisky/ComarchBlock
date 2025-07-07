using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class TraSelemCechy
{
    public int TsCTsCid { get; set; }

    public int TsCTrSid { get; set; }

    public int TsCCecha1DeAid { get; set; }

    public short TsCCecha1Format { get; set; }

    public string TsCCecha1Kod { get; set; } = null!;

    public string TsCCecha1Wartosc { get; set; } = null!;

    public int TsCCecha2DeAid { get; set; }

    public short TsCCecha2Format { get; set; }

    public string TsCCecha2Kod { get; set; } = null!;

    public string TsCCecha2Wartosc { get; set; } = null!;

    public int TsCCecha3DeAid { get; set; }

    public short TsCCecha3Format { get; set; }

    public string TsCCecha3Kod { get; set; } = null!;

    public string TsCCecha3Wartosc { get; set; } = null!;

    public int TsCCecha4DeAid { get; set; }

    public short TsCCecha4Format { get; set; }

    public string TsCCecha4Kod { get; set; } = null!;

    public string TsCCecha4Wartosc { get; set; } = null!;

    public int TsCCecha5DeAid { get; set; }

    public short TsCCecha5Format { get; set; }

    public string TsCCecha5Kod { get; set; } = null!;

    public string TsCCecha5Wartosc { get; set; } = null!;

    public int TsCCecha6DeAid { get; set; }

    public short TsCCecha6Format { get; set; }

    public string TsCCecha6Kod { get; set; } = null!;

    public string TsCCecha6Wartosc { get; set; } = null!;

    public int TsCCecha7DeAid { get; set; }

    public short TsCCecha7Format { get; set; }

    public string TsCCecha7Kod { get; set; } = null!;

    public string TsCCecha7Wartosc { get; set; } = null!;

    public int TsCCecha8DeAid { get; set; }

    public short TsCCecha8Format { get; set; }

    public string TsCCecha8Kod { get; set; } = null!;

    public string TsCCecha8Wartosc { get; set; } = null!;

    public int TsCCecha9DeAid { get; set; }

    public short TsCCecha9Format { get; set; }

    public string TsCCecha9Kod { get; set; } = null!;

    public string TsCCecha9Wartosc { get; set; } = null!;

    public int TsCCecha10DeAid { get; set; }

    public short TsCCecha10Format { get; set; }

    public string TsCCecha10Kod { get; set; } = null!;

    public string TsCCecha10Wartosc { get; set; } = null!;

    public virtual TraSelem TsCTrS { get; set; } = null!;
}
