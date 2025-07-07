using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class AtstElem
{
    public int AteDokumentId { get; set; }

    public int AteDokumentLp { get; set; }

    public string? AteTowarKod { get; set; }

    public string? AteMagazyn { get; set; }

    public int? AteIlosc { get; set; }

    public virtual AtstNag AteDokument { get; set; } = null!;
}
