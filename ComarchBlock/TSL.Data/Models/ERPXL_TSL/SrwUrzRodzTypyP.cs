using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrwUrzRodzTypyP
{
    public int SrxSurid { get; set; }

    public int SrxStpid { get; set; }

    public int? SrxCzasCyklu { get; set; }

    public byte? SrxCzasCykluJedn { get; set; }

    public virtual SrwUrzRodzaje SrxSur { get; set; } = null!;
}
