using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktLudnoscGu
{
    public int LudCzdgid { get; set; }

    public string LudDirtyOrgId { get; set; } = null!;

    public int? LudDzialid { get; set; }

    public int? LudGeoid { get; set; }

    public int? LudGustwrGrId { get; set; }

    public int? LudGustwrId { get; set; }

    public int? LudGuswynId { get; set; }

    public int LudId { get; set; }

    public decimal? LudIlosc { get; set; }

    public int? LudInsertSubTransformationId { get; set; }

    public int LudInsertTransformationId { get; set; }

    public int LudLugid { get; set; }

    public string? LudOpis { get; set; }

    public string LudOrgId { get; set; } = null!;

    public int LudPlecId { get; set; }

    public DateTime LudTsinsert { get; set; }

    public DateTime LudTsupdate { get; set; }

    public int? LudUpdateSubTransformationId { get; set; }

    public int LudUpdateTransformationId { get; set; }

    public int LudZrodgid { get; set; }
}
