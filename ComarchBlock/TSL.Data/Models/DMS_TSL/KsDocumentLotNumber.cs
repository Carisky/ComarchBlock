using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsDocumentLotNumber
{
    public int KstId { get; set; }

    public int KstDocumentId { get; set; }

    public string? KstWarunkiTransakcjiNrPartiiTowaru { get; set; }

    public virtual KsDocument KstDocument { get; set; } = null!;
}
