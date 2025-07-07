using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDeductionSettlement
{
    public int KsuId { get; set; }

    public int KsuDocumentId { get; set; }

    public decimal? KsuRozliczenieOdliczeniaKwota { get; set; }

    public string? KsuRozliczenieOdliczeniaPowod { get; set; }

    public virtual KsDocument KsuDocument { get; set; } = null!;
}
