using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ZaNopisy
{
    public short? ZnOZamTyp { get; set; }

    public int? ZnOZamFirma { get; set; }

    public int ZnOZamNumer { get; set; }

    public short ZnOZamLp { get; set; }

    public byte? ZnOTyp { get; set; }

    public string? ZnOOpis { get; set; }

    public int? ZnOOpisCharset { get; set; }

    public virtual ZamNag ZnOZamNumerNavigation { get; set; } = null!;
}
