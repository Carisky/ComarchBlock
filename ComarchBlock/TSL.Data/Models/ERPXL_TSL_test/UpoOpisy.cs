using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class UpoOpisy
{
    public short UpoGidtyp { get; set; }

    public int? UpoGidfirma { get; set; }

    public int UpoGidnumer { get; set; }

    public short UpoGidlp { get; set; }

    public byte? UpoTyp { get; set; }

    public string? UpoOpis { get; set; }

    public virtual UpoNag UpoGidnumerNavigation { get; set; } = null!;
}
