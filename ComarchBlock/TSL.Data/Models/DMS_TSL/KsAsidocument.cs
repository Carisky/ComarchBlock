using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsAsidocument
{
    public int KsaId { get; set; }

    public int KsaDocumentId { get; set; }

    public string? KsaFakturaZaliczkowaNumer { get; set; }

    public string? KsaFakturaZaliczkowaNumerKseF { get; set; }

    public virtual KsDocument KsaDocument { get; set; } = null!;
}
