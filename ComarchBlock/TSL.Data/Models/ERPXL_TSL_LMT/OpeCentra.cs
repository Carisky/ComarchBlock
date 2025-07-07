using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OpeCentra
{
    public short? OpCOpeTyp { get; set; }

    public int? OpCOpeFirma { get; set; }

    public int OpCOpeNumer { get; set; }

    public short? OpCOpeLp { get; set; }

    public int OpCFrSid { get; set; }

    public virtual FrmStruktura OpCFrS { get; set; } = null!;

    public virtual OpeKarty OpCOpeNumerNavigation { get; set; } = null!;
}
