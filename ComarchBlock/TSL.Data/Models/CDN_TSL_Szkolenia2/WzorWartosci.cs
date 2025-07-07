using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WzorWartosci
{
    public int WzwWzwId { get; set; }

    public int? WzwTwpId { get; set; }

    public string WzwSymbol { get; set; } = null!;

    public string WzwWzor { get; set; } = null!;

    public short WzwNieaktywny { get; set; }

    public decimal WzwDodatkowe { get; set; }

    public int? WzwWzrId { get; set; }

    public virtual TypWyplatum? WzwTwp { get; set; }
}
