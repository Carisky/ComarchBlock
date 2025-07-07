using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class NazRelacje
{
    public short NaRNazTyp { get; set; }

    public short NaRNazLp { get; set; }

    public short NaRObiTyp { get; set; }

    public int? NaRObiFirma { get; set; }

    public int NaRObiNumer { get; set; }

    public short NaRObiLp { get; set; }

    public string? NaRWartoscS { get; set; }

    public virtual Nazwy Nazwy { get; set; } = null!;
}
