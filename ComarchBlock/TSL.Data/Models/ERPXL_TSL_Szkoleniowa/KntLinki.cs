using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KntLinki
{
    public int KnLId { get; set; }

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

    public string? KnLGuid { get; set; }
}
