using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AnkSzablonOdpElem
{
    public int AnkSoEAnkSoeId { get; set; }

    public int AnkSoEAnkSonId { get; set; }

    public int AnkSoELp { get; set; }

    public byte AnkSoEMode { get; set; }

    public decimal AnkSoEPunkty { get; set; }

    public string AnkSoEWartosc { get; set; } = null!;

    public virtual AnkSzablonOdpNag AnkSoEAnkSon { get; set; } = null!;
}
