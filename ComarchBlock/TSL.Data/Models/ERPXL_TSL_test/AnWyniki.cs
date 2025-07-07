using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class AnWyniki
{
    public short? AnWAnZtyp { get; set; }

    public int? AnWAnZfirma { get; set; }

    public int AnWAnZnumer { get; set; }

    public short? AnWAnZlp { get; set; }

    public short AnWObiTyp { get; set; }

    public int? AnWObiFirma { get; set; }

    public int AnWObiNumer { get; set; }

    public short AnWObiLp { get; set; }

    public decimal? AnWWartosc { get; set; }

    public virtual AnZestawy AnWAnZnumerNavigation { get; set; } = null!;
}
