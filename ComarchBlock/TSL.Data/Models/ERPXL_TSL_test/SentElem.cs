using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class SentElem
{
    public int SnEId { get; set; }

    public int? SnESnTid { get; set; }

    public short? SnEPozycja { get; set; }

    public int? SnEKcnid { get; set; }

    public decimal? SnEIlosc { get; set; }

    public string? SnEJm { get; set; }

    public decimal? SnEStawkaVat { get; set; }

    public byte? SnEFlagaVat { get; set; }

    public string? SnEKodOdpadu { get; set; }

    public virtual Sent? SnESnT { get; set; }
}
