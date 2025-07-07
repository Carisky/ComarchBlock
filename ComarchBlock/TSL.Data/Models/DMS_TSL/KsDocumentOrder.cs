using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsDocumentOrder
{
    public int KszId { get; set; }

    public int KszDocumentId { get; set; }

    public DateTime? KszWarunkiTransakcjiDataZamowienia { get; set; }

    public string? KszWarunkiTransakcjiNrZamowienia { get; set; }

    public virtual KsDocument KszDocument { get; set; } = null!;
}
