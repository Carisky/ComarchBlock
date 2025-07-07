using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KntLinki
{
    public short KnLGidtyp { get; set; }

    public int? KnLGidfirma { get; set; }

    public int KnLGidnumer { get; set; }

    public short? KnLGidlp { get; set; }

    public short KnLGrOtyp { get; set; }

    public int? KnLGrOfirma { get; set; }

    public int KnLGrOnumer { get; set; }

    public short? KnLGrOlp { get; set; }

    public short? KnLLisc { get; set; }

    public short? KnLLiczbaPowtorzen { get; set; }

    public int? KnLTstampDataMod { get; set; }
}
