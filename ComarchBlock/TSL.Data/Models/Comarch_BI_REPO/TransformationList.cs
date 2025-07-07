using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_REPO;

public partial class TransformationList
{
    public int TrlId { get; set; }

    public int TrlCompanyId { get; set; }

    public int? TrlUsertransformationId { get; set; }

    public DateTime? TrlLoadDate { get; set; }

    public bool? TrlIsDeleted { get; set; }

    public DateTime? TrlDeleteDate { get; set; }
}
