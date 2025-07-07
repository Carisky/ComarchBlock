using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class SchematyOpakElem
{
    public int SoeSoeid { get; set; }

    public int? SoeSonid { get; set; }

    public int SoeLp { get; set; }

    public int SoeTwrId { get; set; }

    public decimal SoeIlosc { get; set; }

    public virtual SchematyOpakNag? SoeSon { get; set; }

    public virtual Towary SoeTwr { get; set; } = null!;
}
