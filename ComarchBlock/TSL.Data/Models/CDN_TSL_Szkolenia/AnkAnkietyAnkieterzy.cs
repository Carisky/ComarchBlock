using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class AnkAnkietyAnkieterzy
{
    public int AnkAaAAnkAaAid { get; set; }

    public int AnkAaAAnkAnNid { get; set; }

    public int AnkAaALp { get; set; }

    public short AnkAaAPodmiotTyp { get; set; }

    public int AnkAaAPodId { get; set; }

    public virtual AnkAnkietyNag AnkAaAAnkAnN { get; set; } = null!;
}
