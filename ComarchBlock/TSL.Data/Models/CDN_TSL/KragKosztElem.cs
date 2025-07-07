using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KragKosztElem
{
    public int KkeKkeid { get; set; }

    public int KkeKknid { get; set; }

    public string KkeKonto { get; set; } = null!;

    public short KkeStrona { get; set; }

    public virtual KragKosztNag KkeKkn { get; set; } = null!;
}
