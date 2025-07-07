using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MskntOpisy
{
    public short? MsknOKntTyp { get; set; }

    public int? MsknOKntFirma { get; set; }

    public int MsknOKntNumer { get; set; }

    public short MsknOKntLp { get; set; }

    public byte? MsknOTyp { get; set; }

    public string? MsknOOpis { get; set; }

    public int? MsknOCzasModyfikacji { get; set; }
}
