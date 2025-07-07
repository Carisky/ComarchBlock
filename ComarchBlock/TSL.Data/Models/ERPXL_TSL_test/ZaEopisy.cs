using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ZaEopisy
{
    public short? ZeOZamTyp { get; set; }

    public int? ZeOZamFirma { get; set; }

    public int ZeOZamNumer { get; set; }

    public short ZeOZamLp { get; set; }

    public byte? ZeOTyp { get; set; }

    public string? ZeOOpis { get; set; }

    public int? ZeOOpisCharset { get; set; }

    public virtual ZamElem ZamElem { get; set; } = null!;
}
