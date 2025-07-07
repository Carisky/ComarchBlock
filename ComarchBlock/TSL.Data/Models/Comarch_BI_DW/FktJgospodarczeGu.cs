using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktJgospodarczeGu
{
    public int JgoId { get; set; }

    public int JgoZrodgid { get; set; }

    public int JgoCzdgid { get; set; }

    public int? JgoGeoid { get; set; }

    public int JgoDzialid { get; set; }

    public string JgoOrgId { get; set; } = null!;

    public string JgoDirtyOrgId { get; set; } = null!;

    public string? JgoOpis { get; set; }

    public int JgoUpdateTransformationId { get; set; }

    public int? JgoUpdateSubTransformationId { get; set; }

    public int JgoInsertTransformationId { get; set; }

    public int? JgoInsertSubTransformationId { get; set; }

    public DateTime JgoTsinsert { get; set; }

    public DateTime JgoTsupdate { get; set; }

    public decimal? JgoIlosc { get; set; }

    public int? JgoGustwrId { get; set; }

    public decimal? JgoMcena { get; set; }

    public int? JgoGustwrGrId { get; set; }

    public decimal? JgoMindexQgw { get; set; }

    public decimal? JgoMindexQow { get; set; }

    public decimal? JgoMindexQop { get; set; }

    public decimal? JgoMindexQgp { get; set; }

    public decimal? JgoMindexRgw { get; set; }

    public decimal? JgoMindexRow { get; set; }

    public decimal? JgoMindexRop { get; set; }

    public decimal? JgoMindexRgp { get; set; }

    public decimal? JgoGuspkb { get; set; }

    public int? JgoGuswynId { get; set; }

    public decimal? JgoMwynikFinansowy { get; set; }

    public int? JgoLugid { get; set; }

    public int? JgoPlecId { get; set; }

    public virtual WymDzialyGu JgoDzial { get; set; } = null!;

    public virtual WymGeografium? JgoGeo { get; set; }

    public virtual WymGustowary? JgoGustwr { get; set; }

    public virtual WymGustowaryGr? JgoGustwrGr { get; set; }

    public virtual WymGuswynFinansowy? JgoGuswyn { get; set; }

    public virtual WymLudnoscGrupyGu? JgoLug { get; set; }

    public virtual WymPlecGu? JgoPlec { get; set; }

    public virtual WymZrodloDanych JgoZrodg { get; set; } = null!;
}
