using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrtKst
{
    public int SktId { get; set; }

    public string? SktSymbol { get; set; }

    public decimal? SktStawka { get; set; }

    public string? SktNazwa { get; set; }

    public int? SktParentId { get; set; }

    public short? SktWersja { get; set; }

    public byte? SktPoziom { get; set; }
}
