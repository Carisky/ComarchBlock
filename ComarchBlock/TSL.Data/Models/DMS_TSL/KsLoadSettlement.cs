using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsLoadSettlement
{
    public int KslId { get; set; }

    public int KslDocumentId { get; set; }

    public decimal? KslRozliczenieObciazeniaKwota { get; set; }

    public string? KslRozliczenieObciazeniaPowod { get; set; }

    public virtual KsDocument KslDocument { get; set; } = null!;
}
