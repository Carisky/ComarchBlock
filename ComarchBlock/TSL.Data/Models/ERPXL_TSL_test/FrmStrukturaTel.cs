using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class FrmStrukturaTel
{
    public int FrtelId { get; set; }

    public int? FrtelFrsid { get; set; }

    public string? FrtelTelefon { get; set; }

    public virtual FrmStruktura? FrtelFrs { get; set; }
}
