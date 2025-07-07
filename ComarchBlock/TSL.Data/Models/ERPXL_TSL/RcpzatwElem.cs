using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class RcpzatwElem
{
    public int RzeRznid { get; set; }

    public short RzeLp { get; set; }

    public DateTime RzeCzas { get; set; }

    public short RzePrcTyp { get; set; }

    public int RzePrcNumer { get; set; }

    public short RzeFrsTyp { get; set; }

    public int RzeFrsNumer { get; set; }

    public virtual PrcKarty RzePrcNumerNavigation { get; set; } = null!;

    public virtual RcpzatwNag RzeRzn { get; set; } = null!;
}
