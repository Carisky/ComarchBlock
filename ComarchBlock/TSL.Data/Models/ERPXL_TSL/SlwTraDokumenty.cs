using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SlwTraDokumenty
{
    public int SldSltid { get; set; }

    public short SldDokTyp { get; set; }

    public virtual SlwTransakcje SldSlt { get; set; } = null!;
}
