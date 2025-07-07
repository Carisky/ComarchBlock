using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class RejestracjaZgodTrescJezykObcy
{
    public int RztjRztjid { get; set; }

    public int RztjRztid { get; set; }

    public short RztjJezykId { get; set; }

    public string RztjTresc { get; set; } = null!;

    public virtual RejestracjaZgodTresc RztjRzt { get; set; } = null!;
}
