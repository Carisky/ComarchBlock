using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Filtry
{
    public int FilProcId { get; set; }

    public int FilListaId { get; set; }

    public short FilLp { get; set; }

    public short FilStaTyp { get; set; }

    public int? FilStaFirma { get; set; }

    public int FilStaNumer { get; set; }

    public short? FilStaLp { get; set; }

    public string? FilNazwa { get; set; }

    public string? FilFiltrSym { get; set; }

    public string? FilFiltrSql { get; set; }

    public string? FilFiltrIsam { get; set; }

    public byte FilDomyslny { get; set; }

    public byte? FilZapisujHistorie { get; set; }
}
