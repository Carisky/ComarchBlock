using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KntWeryfRachHist
{
    public int KwrhKwrhid { get; set; }

    public int KwrhKntId { get; set; }

    public string KwrhNip { get; set; } = null!;

    public string KwrhRachunekNr { get; set; } = null!;

    public DateTime KwrhData { get; set; }

    public string KwrhIdOdpytania { get; set; } = null!;

    public int KwrhStatus { get; set; }

    public virtual Kontrahenci KwrhKnt { get; set; } = null!;
}
