using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class FormyPlatnosciDf
{
    public int FpdFpdid { get; set; }

    public int FpdDflp { get; set; }

    public int FpdFplId { get; set; }

    public int? FpdNumer { get; set; }

    public string FpdNazwa { get; set; } = null!;

    public virtual FormyPlatnosci FpdFpl { get; set; } = null!;
}
