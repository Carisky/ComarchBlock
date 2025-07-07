using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TypWyplataStaz
{
    public int TwsTwsId { get; set; }

    public int TwsTwpId { get; set; }

    public int TwsStaz { get; set; }

    public decimal TwsProcent { get; set; }

    public virtual TypWyplatum TwsTwp { get; set; } = null!;
}
