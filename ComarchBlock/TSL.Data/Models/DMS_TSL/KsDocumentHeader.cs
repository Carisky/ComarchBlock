using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsDocumentHeader
{
    public int KshId { get; set; }

    public int KshDocumentId { get; set; }

    public string KshNumerReferencyjnyKseF { get; set; } = null!;

    public string? KshKodSystemowy { get; set; }

    public string? KshWersjaSchemy { get; set; }

    public short KshWariantFormularza { get; set; }

    public DateTime? KshDataWytworzeniaFa { get; set; }

    public string? KshNazwaSystemuErp { get; set; }

    public virtual KsDocument KshDocument { get; set; } = null!;
}
