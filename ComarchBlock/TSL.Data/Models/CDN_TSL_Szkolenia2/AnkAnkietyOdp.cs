using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class AnkAnkietyOdp
{
    public int AnkAnOAnkAnOid { get; set; }

    public int? AnkAnOAnkSpOid { get; set; }

    public int AnkAnOAnkAnPid { get; set; }

    public int AnkAnOLp { get; set; }

    public byte AnkAnOMode { get; set; }

    public decimal AnkAnOPunkty { get; set; }

    public string AnkAnOWartosc { get; set; } = null!;

    public virtual AnkAnkietyPyt AnkAnOAnkAnP { get; set; } = null!;
}
