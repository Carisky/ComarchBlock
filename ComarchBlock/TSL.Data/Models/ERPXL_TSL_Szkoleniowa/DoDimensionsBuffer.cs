using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class DoDimensionsBuffer
{
    public DateOnly DateCreated { get; set; }

    public DateOnly DateDimActive { get; set; }

    public int DimId { get; set; }

    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Elementname { get; set; }

    public int? Type { get; set; }

    public int? WmrParId { get; set; }

    public string? Rnazwa { get; set; }

    public string? WmrNazwa { get; set; }

    public string? WmrOpis { get; set; }

    public int? WmrTyp { get; set; }

    public int? TypP { get; set; }

    public string? WmrKonto { get; set; }

    public string? KksKonto { get; set; }

    public string? KksNazwa { get; set; }

    public string? Val1 { get; set; }

    public string? Val2 { get; set; }

    public string? Val3 { get; set; }
}
