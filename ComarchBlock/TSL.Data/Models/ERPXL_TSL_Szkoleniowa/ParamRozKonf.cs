using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ParamRozKonf
{
    public int PrkId { get; set; }

    public short? PrkObiTyp { get; set; }

    public int? PrkObiFirma { get; set; }

    public int? PrkObiNumer { get; set; }

    public short? PrkObiLp { get; set; }

    public short PrkObiSubLp { get; set; }

    public short? PrkPozycja { get; set; }

    public int? PrkAtkId { get; set; }

    public int? PrkDefPytId { get; set; }

    public byte? PrkEdycja { get; set; }

    public byte? PrkWymagaj { get; set; }

    public byte? PrkKopiuj { get; set; }
}
