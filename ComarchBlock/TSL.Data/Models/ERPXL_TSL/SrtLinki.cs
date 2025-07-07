using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SrtLinki
{
    public short SrlGidtyp { get; set; }

    public int? SrlGidfirma { get; set; }

    public int SrlGidnumer { get; set; }

    public short? SrlGidlp { get; set; }

    public short SrlGrOtyp { get; set; }

    public int? SrlGrOfirma { get; set; }

    public int SrlGrOnumer { get; set; }

    public short? SrlGrOlp { get; set; }

    public short? SrlLisc { get; set; }

    public short? SrlLiczbaPowtorzen { get; set; }

    public int? SrlTstampDataMod { get; set; }
}
