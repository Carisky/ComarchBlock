using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrtOpisy
{
    public short? SrOSrtTyp { get; set; }

    public int? SrOSrtFirma { get; set; }

    public int SrOSrtNumer { get; set; }

    public short SrOSrtLp { get; set; }

    public byte? SrOTyp { get; set; }

    public string? SrOOpis { get; set; }

    public virtual SrtKarty SrOSrtNumerNavigation { get; set; } = null!;
}
