using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class TwrStanyBufor
{
    public int? TsbData { get; set; }

    public short? TsbTwrTyp { get; set; }

    public int? TsbTwrFirma { get; set; }

    public int? TsbTwrNumer { get; set; }

    public short? TsbTwrLp { get; set; }

    public short? TsbMagTyp { get; set; }

    public int? TsbMagFirma { get; set; }

    public int? TsbMagNumer { get; set; }

    public short? TsbMagLp { get; set; }

    public decimal? TsbKsiegowaNetto { get; set; }

    public decimal? TsbRzeczywistaNetto { get; set; }

    public decimal? TsbIlSpr { get; set; }

    public decimal? TsbIlMag { get; set; }
}
