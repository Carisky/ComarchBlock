using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class RcpzatwNag
{
    public int RznId { get; set; }

    public DateTime? RznDataOd { get; set; }

    public DateTime? RznDataDo { get; set; }

    public short? RznZamkniety { get; set; }

    public virtual ICollection<RcpzatwElem> RcpzatwElems { get; set; } = new List<RcpzatwElem>();
}
