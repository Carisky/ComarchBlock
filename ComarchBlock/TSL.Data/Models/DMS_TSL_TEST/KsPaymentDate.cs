using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsPaymentDate
{
    public int KspId { get; set; }

    public int KspDocumentId { get; set; }

    public DateTime? KspTerminPlatnosci { get; set; }

    public string? KspTerminPlatnosciOpis { get; set; }

    public virtual KsDocument KspDocument { get; set; } = null!;
}
