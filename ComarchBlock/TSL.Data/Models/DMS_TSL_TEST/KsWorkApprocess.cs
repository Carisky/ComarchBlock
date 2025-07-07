using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsWorkApprocess
{
    public int KswId { get; set; }

    public int KswApdid { get; set; }

    public int? KswDocumentId { get; set; }

    public DateTime? KswCreateDate { get; set; }

    public int KswOperatorId { get; set; }

    public byte KswStatus { get; set; }

    public bool KswArchival { get; set; }
}
