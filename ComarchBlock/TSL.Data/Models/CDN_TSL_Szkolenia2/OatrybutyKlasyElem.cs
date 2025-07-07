using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OatrybutyKlasyElem
{
    public int AkeAkeId { get; set; }

    public int AkeAtkId { get; set; }

    public string AkeWartosc { get; set; } = null!;

    public string? AkeImportRowId { get; set; }

    public virtual OatrybutyKlasy AkeAtk { get; set; } = null!;
}
