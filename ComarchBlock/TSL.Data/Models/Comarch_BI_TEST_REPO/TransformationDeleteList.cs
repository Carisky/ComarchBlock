using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class TransformationDeleteList
{
    public int TdlId { get; set; }

    public int TdlConnectionid { get; set; }

    public int? TdlTransformationid { get; set; }

    public bool? TdlIsdeleted { get; set; }

    public DateTime? TdlDeleteDate { get; set; }

    public int? TdlCompanyId { get; set; }

    public virtual Connection TdlConnection { get; set; } = null!;
}
