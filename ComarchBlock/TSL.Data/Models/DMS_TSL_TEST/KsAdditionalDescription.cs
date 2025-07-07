using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsAdditionalDescription
{
    public int KsoId { get; set; }

    public int KsoDocumentId { get; set; }

    public string? KsoDodatkowyOpisNrWiersza { get; set; }

    public string? KsoDodatkowyOpisKlucz { get; set; }

    public string? KsoDodatkowyOpisWartosc { get; set; }

    public virtual KsDocument KsoDocument { get; set; } = null!;
}
