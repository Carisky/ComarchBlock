using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocumentFooter
{
    public int KsfId { get; set; }

    public int KsfDocumentId { get; set; }

    public string? KsfStopkaFaktury { get; set; }

    public string? KsfStopkaRejestrInny { get; set; }

    public string? KsfStopkaKrs { get; set; }

    public string? KsfStopkaRegon { get; set; }

    public string? KsfStopkaBdo { get; set; }

    public virtual KsDocument KsfDocument { get; set; } = null!;
}
