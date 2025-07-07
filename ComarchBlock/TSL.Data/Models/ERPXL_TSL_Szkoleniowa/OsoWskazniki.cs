using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class OsoWskazniki
{
    public int OwkId { get; set; }

    public int? OwkOroId { get; set; }

    public decimal? OwkWartoscProgowa { get; set; }

    public decimal? OwkProcent { get; set; }

    public virtual OsoStaleRoczne? OwkOro { get; set; }
}
