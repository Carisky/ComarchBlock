using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TraElemRelacje
{
    public int TeRTeRid { get; set; }

    public short TeRParentTyp { get; set; }

    public int TeRParentId { get; set; }

    public short TeRChildTyp { get; set; }

    public int TeRChildId { get; set; }

    public short? TeRFlaga { get; set; }

    public decimal? TeRInfo { get; set; }

    public decimal? TeRInfo2 { get; set; }
}
