using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocumentAgreement
{
    public int KsgId { get; set; }

    public int KsgDocumentId { get; set; }

    public DateTime KsgWarunkiTransakcjiDataUmowy { get; set; }

    public string? KsgWarunkiTransakcjiNrUmowy { get; set; }

    public virtual KsDocument KsgDocument { get; set; } = null!;
}
