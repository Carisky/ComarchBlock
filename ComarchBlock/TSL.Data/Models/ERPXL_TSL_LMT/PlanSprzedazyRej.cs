using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class PlanSprzedazyRej
{
    public int PsrPspId { get; set; }

    public int PsrRejId { get; set; }

    public decimal? PsrWartosc { get; set; }

    public virtual PlanSprzedazy PsrPsp { get; set; } = null!;

    public virtual Rejony PsrRej { get; set; } = null!;
}
