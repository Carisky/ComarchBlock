using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class OpeOpisy
{
    public short? OpOOpeTyp { get; set; }

    public int? OpOOpeFirma { get; set; }

    public int OpOOpeNumer { get; set; }

    public short OpOOpeLp { get; set; }

    public byte? OpOTyp { get; set; }

    public string? OpOOpis { get; set; }

    public virtual OpeKarty OpOOpeNumerNavigation { get; set; } = null!;
}
