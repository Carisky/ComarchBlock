using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class PrlnOpisy
{
    public int PrlnOPrlnId { get; set; }

    public byte? PrlnOTyp { get; set; }

    public string? PrlnOOpis { get; set; }

    public virtual ProlongNag PrlnOPrln { get; set; } = null!;
}
