using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class Wyplaty
{
    public int WplId { get; set; }

    public int? WplLplid { get; set; }

    public short? WplNumer { get; set; }

    public int? WplOsoNumer { get; set; }

    public int? WplUmoNumer { get; set; }

    public decimal? WplDoWyplaty { get; set; }

    public byte? WplStatus { get; set; }

    public virtual ListyPlac? WplLpl { get; set; }

    public virtual ICollection<WypElem> WypElems { get; set; } = new List<WypElem>();
}
