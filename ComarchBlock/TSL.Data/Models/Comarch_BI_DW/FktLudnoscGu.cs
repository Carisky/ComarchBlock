using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktLudnoscGu
{
    public int LudId { get; set; }

    public int LudZrodgid { get; set; }

    public int LudCzdgid { get; set; }

    public int? LudGeoid { get; set; }

    public int LudLugid { get; set; }

    public string LudOrgId { get; set; } = null!;

    public int LudPlecId { get; set; }

    public string LudDirtyOrgId { get; set; } = null!;

    public string? LudOpis { get; set; }

    public int LudUpdateTransformationId { get; set; }

    public int? LudUpdateSubTransformationId { get; set; }

    public int LudInsertTransformationId { get; set; }

    public int? LudInsertSubTransformationId { get; set; }

    public DateTime LudTsinsert { get; set; }

    public DateTime LudTsupdate { get; set; }

    public decimal? LudIlosc { get; set; }

    public int? LudDzialid { get; set; }

    public int? LudGustwrId { get; set; }

    public int? LudGustwrGrId { get; set; }

    public int? LudGuswynId { get; set; }

    public virtual WymDzialyGu? LudDzial { get; set; }

    public virtual WymGeografium? LudGeo { get; set; }

    public virtual WymGustowary? LudGustwr { get; set; }

    public virtual WymGustowaryGr? LudGustwrGr { get; set; }

    public virtual WymGuswynFinansowy? LudGuswyn { get; set; }

    public virtual WymLudnoscGrupyGu LudLug { get; set; } = null!;

    public virtual WymPlecGu LudPlec { get; set; } = null!;

    public virtual WymZrodloDanych LudZrodg { get; set; } = null!;
}
