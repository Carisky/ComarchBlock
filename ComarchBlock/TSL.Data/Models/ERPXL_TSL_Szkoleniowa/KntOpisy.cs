using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntOpisy
{
    public short? KnOKntTyp { get; set; }

    public int? KnOKntFirma { get; set; }

    public int KnOKntNumer { get; set; }

    public short KnOKntLp { get; set; }

    public byte? KnOTyp { get; set; }

    public string? KnOOpis { get; set; }

    public int? KnOCzasModyfikacji { get; set; }
}
